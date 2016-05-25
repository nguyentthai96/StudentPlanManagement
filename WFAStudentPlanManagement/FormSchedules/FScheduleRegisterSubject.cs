using DevExpress.XtraScheduler;
using StudentPlanManagementData.CustomModels;
using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStudentPlanManagement.FormSchedules
{
    public partial class FScheduleRegisterSubject : Form
    {
        private string strStudentId;
        private string strSemesterId;
        private List<CSubjectsEntity> listSubjects;
        private List<CInstructorEntity> listInstructors;
        public FScheduleRegisterSubject(string strStudentId, string strSemesterId)
        {
            this.strStudentId = strStudentId;
            this.strSemesterId = strSemesterId;
            InitializeComponent();
        }

        private void FScheduleRegisterSubject_Load(object sender, EventArgs e)
        {
            loadCmbSubject();
        }

        private void loadCmbSubject()
        {
            listSubjects = StudentPlanManagementBusiness.CSubjectBusness.loadListSubjectFullTable();

            foreach (CSubjectsEntity s in listSubjects)
            {
                cmbSubject.Properties.Items.Add(s.SubjectName);
            }
            cmbSubject.SelectedIndex = 0;
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCmbInstructors();
            loadComponentInfor();
        }

        private void loadComponentInfor()
        {
            txtNuberLessonOfDay.Text = listSubjects[cmbSubject.SelectedIndex].NumberLessonOfDay.ToString();
            txtNumberOfCreadit.Text = listSubjects[cmbSubject.SelectedIndex].NumberOfCredits.ToString();
        }
        private void loadCmbInstructors()
        {
            string strSubjectId = listSubjects[cmbSubject.SelectedIndex].SubjectId;

            listInstructors = StudentPlanManagementBusiness.CInstructorBusness.loadInstructorForSubject(strSubjectId);
            if (listInstructors.Count == 0)
            {
                listInstructors = StudentPlanManagementBusiness.CInstructorBusness.loadInstructorFullTable();
            }

            cmbInstructor.Properties.Items.Clear();
            foreach (CInstructorEntity i in listInstructors)
            {
                cmbInstructor.Properties.Items.Add(i.InstructorName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             int iInstructorId = listInstructors[cmbInstructor.SelectedIndex].InstructorId;
            CSemesterEntityCSubjectsEntity takeDataSemesterSubject = new CSemesterEntityCSubjectsEntity
            {
                StudentId = strStudentId,
                SubjectId = listSubjects[cmbSubject.SelectedIndex].SubjectId,
                SemesterId = strSemesterId,
                DateOfTake = DateTime.Now,
                //Instructor = listInstructors[cmbInstructor.SelectedIndex] lấy vầy tại sao lỗi An entity object cannot be referenced by multiple instances of IEntityChangeTracker.
                //nhưng bỏ nó null không lỗi hoặc lấy như thế này không lỗi takeDataSemesterSubject.Instructor = context.InstructorEntities.SingleOrDefault(s => s.InstructorId == sss);
                // An error occurred while updating the entries. See the inner exception for details. do trùng khóa chính
            };
            #region Tại sao như vầy lại lỗi  Additional information: An error occurred while saving entities that do not expose foreign key properties for their relationships. The EntityEntries property will return null because a single entity cannot be identified as the source of the exception. Handling of exceptions while saving can be made easier by exposing foreign key properties in your entity types. See the InnerException for details.
            //CSemesterEntityCSubjectsEntity takeDataSemesterSubject = new CSemesterEntityCSubjectsEntity();
            //takeDataSemesterSubject.SemesterId = strStudentId;
            //takeDataSemesterSubject.SubjectId = listSubjects[cmbSubject.SelectedIndex].SubjectId;
            //takeDataSemesterSubject.SemesterId = strSemesterId;
            //takeDataSemesterSubject.DateOfTake = DateTime.Now;
            //takeDataSemesterSubject.Instructor = listInstructors[cmbInstructor.SelectedIndex];
            #endregion

            //StudentPlanManagementBusiness.CTakeSubjectBusiness.addSubjectSemester(takeDataSemesterSubject, iInstructorId); //ddang ky moon hoc gop lai lun, khi gop lai nhuoc diem nhap nhanwf nhung no se the hien thuc the dang ky Take la ao, quan trong Schedule hon

            bool firstDaySchedule = true;
            CScheduleEntity scheduleData;
            #region Decryption WeekDays
            int valueWeekDay = weekDayStudy.WeekDays.GetHashCode();
            if (valueWeekDay > 63)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                #endregion
                scheduleData.WeekOfDay = "Thứ bảy";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }
                valueWeekDay -= 64;
            }
            if (valueWeekDay > 31)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                #endregion
                scheduleData.WeekOfDay = "Thứ sáu";
                StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                valueWeekDay -= 32;
            }
            if (valueWeekDay > 15)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                scheduleData.Take = takeDataSemesterSubject;
                #endregion

                scheduleData.WeekOfDay = "Thứ năm";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }
                valueWeekDay -= 16;
            }
            if (valueWeekDay > 7)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                #endregion

                scheduleData.WeekOfDay = "Thứ tư";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }
                valueWeekDay -= 8;
            }
            if (valueWeekDay > 3)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                scheduleData.Take = takeDataSemesterSubject;
                #endregion

                scheduleData.WeekOfDay = "Thứ ba";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }

                valueWeekDay -= 4;
            }
            if (valueWeekDay > 1)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                #endregion

                scheduleData.WeekOfDay = "Thứ hai";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }

                valueWeekDay -= 2;
            }
            if (valueWeekDay > 0)
            {
                #region NewSchedule
                scheduleData = new CScheduleEntity();
                scheduleData.ScheduleId = "S" + StudentPlanManagementBusiness.CScheduleBusiness.countScheduleInTable();
                scheduleData.ScheduleTitle = txtScheduleTitle.Text;
                scheduleData.TimeStart = tmeStart.Time.TimeOfDay;
                scheduleData.TimeEnd = tmeEnd.Time.TimeOfDay;
                scheduleData.ClassRom = txtClassRom.Text;
                #endregion

                scheduleData.WeekOfDay = "Chủ nhật";
                if (firstDaySchedule)
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleRegisterSubjectSemester(scheduleData, takeDataSemesterSubject, iInstructorId);
                    firstDaySchedule = false;
                }
                else
                {
                    StudentPlanManagementBusiness.CScheduleBusiness.addScheduleNonRegisterSubjectSemester(scheduleData, takeDataSemesterSubject);
                }
                valueWeekDay -= 1;
            }
#endregion
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
