using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Compatibility;

namespace WFAStudentPlanManagement.FormSchedules
{
    public partial class FScheduleTable : Form
    {
        private string strStudentId;
        private string strSemesterId;
        public FScheduleTable(string strStudentId, string strSemesterId)
        {
            this.strStudentId = strStudentId;
            this.strSemesterId = strSemesterId;
            InitializeComponent();
            schedulerControl.Start = DateTime.Now;
        }

        private void FScheduleTable_Load(object sender, EventArgs e)
        {
            DataTable dtScheduler = new DataTable();
            dtScheduler = StudentPlanManagementBusiness.CScheduleBusiness.loadScheduleFull(strStudentId,strSemesterId);
            
            schedulerControl.Storage.Resources.DataSource = dtScheduler;
            //schedulerControl.Storage.Resources.Mappings.Id = dtScheduler.Columns["ScheduleId"].ToString();
            schedulerControl.Storage.Resources.Mappings.Caption= dtScheduler.Columns["ScheduleTitle"].ToString();
            FillData();
        }

        private void FillData()
        {
            AppointmentCustomFieldMapping customNameMapping = new AppointmentCustomFieldMapping("CustomName", "CustomName");
            AppointmentCustomFieldMapping customStatusMapping = new AppointmentCustomFieldMapping("CustomStatus", "CustomStatus");
            schedulerStorage.Appointments.CustomFieldMappings.Add(customNameMapping);
            schedulerStorage.Appointments.CustomFieldMappings.Add(customStatusMapping);
            //            schedulerStorage1.Appointments.ResourceSharing = true;

            // FillResourcesStorage(schedulerStorage1.Resources.Items, resDataFileName);

            FillAppointmentsStorage(schedulerStorage.Appointments.Items);
        }

        void FillAppointmentsStorage(AppointmentCollection c)
        {
            DataTable dtSchedulerFill = new DataTable();

            dtSchedulerFill = StudentPlanManagementBusiness.CScheduleBusiness.loadScheduleFull(strStudentId,strSemesterId);
            for (int i = 0; i < dtSchedulerFill.Rows.Count; i++)
            {
                Appointment ap = StaticAppointmentFactory.CreateAppointment(AppointmentType.Pattern);
                ap = schedulerControl.Storage.CreateAppointment(AppointmentType.Normal, DateTime.Now, DateTime.Now.AddDays(1), "Test appointment");

                ap.Subject = dtSchedulerFill.Rows[i]["SubjectName"].ToString();
                ap.Description = dtSchedulerFill.Rows[i]["ScheduleTitle"].ToString()+" "+ dtSchedulerFill.Rows[i]["ClassRom"].ToString();

                ap.Start =(DateTime)(dtSchedulerFill.Rows[i]["TimeStart"]);
                ap.End = (DateTime)(dtSchedulerFill.Rows[i]["TimeEnd"]);
               
                c.Add(ap);
            }
        }

        private void schedulerContro_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            Appointment apt = e.Appointment;

            // Required to open the recurrence form via context menu.
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage.Appointments.IsNewAppointment(apt);

            // Create a custom form.
           FScheduleRegisterSubject myForm = new FScheduleRegisterSubject(strStudentId,strSemesterId);
            myForm.ShowDialog();
            myForm.Close();
            myForm.Dispose();
            FillData();
        }

    }
}
