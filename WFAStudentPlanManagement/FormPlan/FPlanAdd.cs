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

namespace WFAStudentPlanManagement.FormPlan
{
    public partial class FPlanAdd : Form
    {
        private string strStudentId;
        private string strSemesterId;
        private CPlanEntity planData;
        public FPlanAdd(string strStudentId, string strSemesterId)
        {
            this.strStudentId = strStudentId;
            this.strSemesterId = strSemesterId;
            InitializeComponent();
        }

        bool bReminDayEdited = false;
        private void dtRemindDay_Enter(object sender, EventArgs e)
        {
            bReminDayEdited = true;
        }

        private void dtRemindDay_Leave(object sender, EventArgs e)
        {
            if (bReminDayEdited)
            {
                DateTime dtPresentation;
                DateTime.TryParse(txtDateStart.Text + " " + tmStart.Time.ToShortTimeString(), out dtPresentation);
                if (dtPresentation < DateTime.Now)
                {
                    MessageBox.Show("Presentation day wrong.");
                    return;
                }

                if (dtRemindDay.DateTime > dtPresentation || dtRemindDay.DateTime < DateTime.Now.Date)
                {
                    MessageBox.Show("Remind cannot last start plan.");
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentPlanManagementBusiness.CPlanBusiness.addPlan( getDataForm());
            this.Close();
        }
        private CPlanEntity getDataForm()
        {
            planData = new CPlanEntity
            {
                Student = StudentPlanManagementBusiness.CStudentBusiness.getStudentData(strStudentId),
                PlandId = StudentPlanManagementBusiness.CPlanBusiness.getPlanIdNew(),
                PlanTitle = txtPlanTitle.Text,
                Contents = txtContextPlan.Text,
                Describe = txtDescribe.Text,
                DayofRemind = dtRemindDay.DateTime,
                Duration = new CDurationActive
                {
                    DateStart = DateTime.Parse(txtDateStart.Text),
                    DateEnd = DateTime.Parse(txtDateEnd.Text),
                    TimeStart = tmStart.Time.TimeOfDay,
                    TimeEnd=tmEnd.Time.TimeOfDay
                }
            };
            return planData;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
