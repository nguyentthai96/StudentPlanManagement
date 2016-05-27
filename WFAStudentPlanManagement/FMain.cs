using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentPlanManagementBusiness;
using StudentPlanManagementData.Models;
using System.Threading;
using WFAStudentPlanManagement.FormSchedules;
using WFAStudentPlanManagement.FormAccounts;

namespace WFAStudentPlanManagement
{
    public partial class FMain : DevExpress.XtraEditors.XtraForm
    {
        private CStudentEntity student;
        private CSemesterEntity semester;
        private FormAccounts.FAccountSignIn frmAccountSign;
        private FormSchedules.FScheduleTable frmScheduleTable;

        public FMain()
        {
            this.student = null;
            this.semester = new CSemesterEntity();
            this.semester.SemesterId = "HK4";
            this.semester.SemesterName = "Học kỳ 4";
            this.semester.SchoolYears = "2015-2016";
            InitializeComponent(); 
        }

        private void GetStudentId_Event(string strStudentId)
        {
            frmAccountSign.Hide();
            student = new CStudentEntity();
            student = CStudentBusiness.getStudentData(strStudentId);
            if ( childThread.ThreadState == ThreadState.Aborted)
            {
                childThread.DisableComObjectEagerCleanup();
                ThreadStart childref = new ThreadStart(loadDelay);
                childThread = new Thread(childref);
            }
            childThread.Start();
            Thread.Sleep(600);
            reLblHelloInfor("Hello, "+ student.StudentName);
            this.barManagerAccount.SetPopupContextMenu(this.lblStudentName, this.popupMenuAccount);
            loadFormTableTime();
        }

        private void loadFormTableTime()
        {
            frmScheduleTable = new FormSchedules.FScheduleTable(student.StudentId, semester.SemesterId);
            frmScheduleTable.MdiParent = this;
            frmScheduleTable.Show();
            childThread.Abort();
        }
        Thread childThread;
        private void FMain_Load(object sender, EventArgs e)
        {
            loadHelloFormLogin();
            ThreadStart childref = new ThreadStart(loadDelay);
            childThread = new Thread(childref);
        }
        private void loadDelay()
        {
            Form frm = new Form();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            frm.StartPosition = FormStartPosition.CenterParent;
            
            DevExpress.XtraEditors.MarqueeProgressBarControl progress = new MarqueeProgressBarControl();
            progress.Size = new Size(380, 48);
            progress.Location = new Point(433, 344);
            frm.Controls.Add(progress);
            DevExpress.XtraEditors.LabelControl labelLoad = new LabelControl();
            labelLoad.Text = "Data Loadding....";
            labelLoad.Font = new Font(FontFamily.GenericSansSerif,28,FontStyle.Bold);
            labelLoad.ForeColor = Color.Green;
            labelLoad.Location = new Point(433, 400);
            frm.Controls.Add(labelLoad);
            frm.ShowDialog();
        }
        
        private void loadHelloFormLogin()
        { 
            frmAccountSign = new FormAccounts.FAccountSignIn();
            frmAccountSign.LoginSuccessHandler += new FormAccounts.FAccountSignIn.GetStudentIdLoginSuccessHandler(GetStudentId_Event);
            frmAccountSign.MdiParent = this;
            frmAccountSign.Show();
            reLblHelloInfor("Hello You!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                if (this.Contains(frmScheduleTable)==false)
                {
                    loadFormTableTime();
                }
            }
            else
            {
                MessageBox.Show("You are need login account...");
            }
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            if (student==null)
            {
                return;
            }
            FormPlan.FPlanAdd frmPlanAdd= new FormPlan.FPlanAdd(student.StudentId);
            frmPlanAdd.StartPosition = FormStartPosition.CenterParent;
            frmPlanAdd.ShowDialog();
        }

        private void pbtnEditStudentInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (student != null)
            {
            FStudentInformationEdit frmStudentInforEdit = new FStudentInformationEdit(student.StudentId);
            frmStudentInforEdit.StartPosition = FormStartPosition.CenterParent;
            frmStudentInforEdit.ShowDialog();
        }
            else
            {
                MessageBox.Show("You are not login account....");
            }
}

        private void pbtnInitializerSubjectSchedule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (student==null)
            {
                MessageBox.Show("You are not login account....");
                return;
            }
           FScheduleRegisterSubject frmResgisterSubject = new FScheduleRegisterSubject(student.StudentId, semester.SemesterId);
            frmResgisterSubject.StartPosition = FormStartPosition.CenterParent;
            frmResgisterSubject.ShowDialog();
        }

        private void pbtnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            student = null;
            this.barManagerAccount.SetPopupContextMenu(this.lblStudentName, null);
            foreach (var item in this.MdiChildren)
            {
                item.Close();
                item.Dispose();
            }
            loadHelloFormLogin();
        }

        private void reLblHelloInfor(string str)
        {
            lblStudentName.Text = str;
            int x = this.Width - lblStudentName.Width-50;
            lblStudentName.Location = new Point(x, lblStudentName.Location.Y);
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                MessageBox.Show("You are not login account....");
                return;
            }
            FStudentInformationLoad frmStudentInfor = new FStudentInformationLoad(student.StudentId);
                frmStudentInfor.StartPosition = FormStartPosition.CenterParent;
                frmStudentInfor.ShowDialog();
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            reLblHelloInfor(lblStudentName.Text);
        }

        private void pbtnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (student == null)
            {
                MessageBox.Show("You are not login account....");
                return;
            }
            FAccountEditPassword frmAccountPasswordChange = new FAccountEditPassword(student.StudentId);
            frmAccountPasswordChange.StartPosition = FormStartPosition.CenterParent;
            frmAccountPasswordChange.ShowDialog();
        }
    }
}