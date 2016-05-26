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

namespace WFAStudentPlanManagement.FormAccounts
{
    public partial class FAccountAdd : Form
    {
        public delegate void AccountLoginHandler(string strSudentId, string strPassword);
        public event AccountLoginHandler GetStudentIdLogin;
        private CAccountEntity acc;
        public FAccountAdd()
        {
            acc = new CAccountEntity();
            InitializeComponent();
        }

        private void txtStudentId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Input confirm password wrong.");
                return;
            }

            acc.Password = txtPassword.Text;
            acc.StudentId = txtStudentId.Text;
            acc.IsAcctive = true;
            acc.DateOfRegister = DateTime.Now;
            FStudentInformationAdd frmStudentInfor = new FStudentInformationAdd(acc.StudentId);
            frmStudentInfor.StartPosition = FormStartPosition.CenterParent;
            frmStudentInfor.ShowDialog();
            if (StudentPlanManagementBusiness.CAccountBusiness.addAccount(acc))
            {
                AssginStudentId(this.acc.StudentId, acc.Password);
                this.Close();
            }
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void AssginStudentId(string strStudentId, string strPassword)
        {
            if (GetStudentIdLogin != null)
            {
                GetStudentIdLogin(strStudentId,strPassword);
            }
        }
    }
}
