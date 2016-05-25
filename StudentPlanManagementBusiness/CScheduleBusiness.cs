using StudentPlanManagementData;
using System;
using System.Linq;
using StudentPlanManagementData.Models;

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