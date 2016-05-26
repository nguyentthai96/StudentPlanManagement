using StudentPlanManagementData;
using System;
using System.Linq;
using StudentPlanManagementData.Models;
using System.Data;

namespace StudentPlanManagementBusiness
{
    public class CScheduleBusiness
    {
        private static StudentPlanManagementContext dbContext;
        public static int countScheduleInTable()
        {
            dbContext = new StudentPlanManagementContext();
            int count =dbContext.ScheduleEntities.Count();
            return count;
        }

        public static void addScheduleRegisterSubjectSemester(CScheduleEntity scheduleData, StudentPlanManagementData.CustomModels.CSemesterEntityCSubjectsEntity takeSubjectSemester, int iInstructorId)
        {
            dbContext = new StudentPlanManagementContext();
            takeSubjectSemester.Instructor= dbContext.InstructorEntities.SingleOrDefault(i => i.InstructorId == iInstructorId);
            try
            {
                dbContext.SubjectsTakesEntities.Add(takeSubjectSemester); //xu ly loi khi tao schedule moi cho mon da dang ky truoc vao take
                dbContext.SaveChanges();
            }
            catch (Exception ex) when (ex.Message== "An error occurred while saving entities that do not expose foreign key properties for their relationships. The EntityEntries property will return null because a single entity cannot be identified as the source of the exception. Handling of exceptions while saving can be made easier by exposing foreign key properties in your entity types. See the InnerException for details." )
            {
                //dbContext.SubjectsTakesEntities.Local.Clear();
                dbContext = new StudentPlanManagementContext();
                //Da save roi khong save nua
                //TODO tim cach tra ve thong bao rang da dang ky subject ay roi phai xoa moi dang ky lai duoc, co the la mo rong chuc nang sau: Bạn đã đăng ký môn này rồi không đăng ký lại nhe, bạn có muốn tiếp tục tạo lịch biểu không
            }
            ///
            scheduleData.Take = dbContext.SubjectsTakesEntities.SingleOrDefault(t => t.StudentId == takeSubjectSemester.StudentId &&
                                                                                t.SemesterId == takeSubjectSemester.SemesterId &&
                                                                                t.SubjectId == takeSubjectSemester.SubjectId
                                                                                  );

            dbContext.ScheduleEntities.Add(scheduleData);
            dbContext.SaveChanges();
        }

        public static DataTable loadScheduleFull(string strStudentId, string strSemesterId)
        {
            dbContext = new StudentPlanManagementContext();

            DataTable table = new DataTable("ScheduleTableStudy");
            table.Columns.Add("ScheduleId", typeof(string));
            table.Columns.Add("ScheduleTitle", typeof(string));
            table.Columns.Add("GetWeekOfDayTypeInt", typeof(int));
            table.Columns.Add("TimeStart", typeof(DateTime));
            table.Columns.Add("TimeEnd", typeof(DateTime));
            table.Columns.Add("ClassRom", typeof(string));
            table.Columns.Add("SubjectName", typeof(string));
            foreach (var s in dbContext.ScheduleEntities)
            {
                DataRow dr = table.NewRow();
                dr["ScheduleId"] = s.ScheduleId;
                dr["ScheduleTitle"] = s.ScheduleTitle;
                dr["GetWeekOfDayTypeInt"] = s.GetWeekOfDayTypeInt;
                //TODO Tinh toan lai thoi gian dr["TimeStart"] = s.TimeStart;
                //TODO Tinh toan lai thoi gian dr["TimeEnd"] = s.TimeEnd;
                dr["ClassRom"] = s.ClassRom;
                dr["SubjectName"] = s.Take.Subject.SubjectName;

                #region Tinh toan thoi gian, hien thi lich hoc trong mot thang hien hanh va thang sau va thang truoc do
                int iMonthNow=DateTime.Now.Month;
                int iYearNow = DateTime.Now.Year;
                iMonthNow--;
                for (int nth = 0; nth < 32; nth++)
                {
                    DataRow drNew = dr;
                    drNew["TimeStart"] = DateTime.Parse(DateTimeOfDayWeekInMont(iYearNow, iMonthNow, (DayOfWeek)s.GetWeekOfDayTypeInt, nth).ToShortDateString() + " " + s.TimeStart);
                    drNew["TimeEnd"] = DateTime.Parse(DateTimeOfDayWeekInMont(iYearNow, iMonthNow, (DayOfWeek)s.GetWeekOfDayTypeInt, nth).ToShortDateString() + " " + s.TimeEnd);
                    table.Rows.Add(drNew.ItemArray);
                    table.ImportRow(drNew);
                }
                #endregion
            }
            return table;
        }

        private static DateTime DateTimeOfDayWeekInMont(int year, int month, DayOfWeek dayWeek, int nth)
        {
            DateTime result = new DateTime(year, month, 1);
            while (result.DayOfWeek != dayWeek)
                result = result.AddDays(1);
            return result.AddDays(7 * (nth - 1));
        }

        public static void addScheduleNonRegisterSubjectSemester(CScheduleEntity scheduleData, StudentPlanManagementData.CustomModels.CSemesterEntityCSubjectsEntity takeSubjectSemester)
        {
            dbContext = new StudentPlanManagementContext();

            scheduleData.Take = dbContext.SubjectsTakesEntities.SingleOrDefault(t => t.StudentId == takeSubjectSemester.StudentId &&
                                                                                t.SemesterId == takeSubjectSemester.SemesterId &&
                                                                                t.SubjectId == takeSubjectSemester.SubjectId
                                                                                  );
            dbContext.ScheduleEntities.Add(scheduleData);
            dbContext.SaveChanges();
        }
    }
}