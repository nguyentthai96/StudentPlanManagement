using StudentPlanManagementBusiness;
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
    public partial class FAccountEditPassword : Form
    {
        private CAccountEntity acc;
        public FAccountEditPassword(string strStudentId)
        {
            acc = new CAccountEntity();
            this.acc.StudentId = strStudentId;
            InitializeComponent();
            txtStudentId.Text = strStudentId;
        }

        private void txtPasswordCurent_KeyUp(object sender, KeyEventArgs e)
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
                txtConfirmPassword.Focus();
            }
        }

        private void txtConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CAccountBusiness.checkPassword(acc.StudentId, txtPasswordCurent.Text)==false)
            {
                MessageBox.Show("Password Current wrong.");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Input confirm password wrong.");
                return;
            }

            acc.Password = txtPassword.Text;
            
            if (StudentPlanManagementBusiness.CAccountBusiness.editAccount(acc))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error change password.");
                return;
            }
            return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
