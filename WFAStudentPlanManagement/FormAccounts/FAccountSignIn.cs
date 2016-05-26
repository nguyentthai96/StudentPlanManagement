using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStudentPlanManagement.FormAccounts
{
    public partial class FAccountSignIn : Form
    {
        public delegate void GetStudentIdLoginSuccessHandler(string strStudentId);
        public event GetStudentIdLoginSuccessHandler LoginSuccessHandler;
        private string strStudentId;
        private string strPassword;
        //ToDo delegate
        public FAccountSignIn()
        {
            InitializeComponent();
        }

        #region Interface Event
        private void txtAccountId_Enter(object sender, EventArgs e)
        {
            txtAccountId.ForeColor = SystemColors.ControlText;
            txtAccountId.ResetText();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = SystemColors.ControlText;
            txtPassword.ResetText();
            txtPassword.Properties.PasswordChar = '*';
        }

        private void txtAccountId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtAccountId_Leave(object sender, EventArgs e)
        {
            if (txtAccountId.Text == "")
            {
                txtAccountId.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                txtAccountId.EditValue = "Account Id";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                DevExpress.XtraEditors.TextEdit temp = new DevExpress.XtraEditors.TextEdit();
                txtPassword.Properties.PasswordChar = temp.Properties.PasswordChar;
                txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                txtPassword.EditValue = "Password";
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
        #endregion

        private bool readFile()
        {
            BinaryReader br;

            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("accFile.t", FileMode.Open));
            }
            catch (IOException e)
            {
                return false;
            }
            try
            {
                int length = br.ReadInt32();
                int[] temp = new int[length];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = int.Parse(br.ReadString());
                }
                strStudentId = DencoderString(temp, length);

                length = int.Parse(br.ReadString());
                temp = new int[length];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = int.Parse(br.ReadString());
                }
                strPassword = DencoderString(temp, length);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return false;
            }
            br.Close();

            return true;
        }

        private bool writeFile()
        {
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream("accFile.t", FileMode.Create));
            }
            catch (IOException e)
            {
                return false;
            }

            //writing into the file
            try
            {
                bw.Write(EncoderString(strStudentId).Length);
                foreach (var i in EncoderString(strStudentId))
                {
                    bw.Write(i + "");
                }
                int length = EncoderString(strPassword).Length;

                bw.Write(length + "");
                foreach (var i in EncoderString(strPassword))
                {
                    bw.Write(i + "");
                }
            }

            catch (IOException e)
            {
                return false;
            }
            bw.Close();
            return true;
        }

        private int[] EncoderString(string str)
        {
            int n = str.Length;
            int[] arrResult = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrResult[i] = ((int)str[i] + n);
            }
            return arrResult;
        }
        private string DencoderString(int[] str, int n)
        {
            string strResult = "";
            foreach (var s in str)
            {
                strResult += ((char)(s - n));
            }
            return strResult;
        }
        private void checkAccountPassword()
        {
            if (StudentPlanManagementBusiness.CAccountBusiness.checkPassword(strStudentId, strPassword))
            {
                if (chkRememberAccount.Checked)
                {
                    writeFile();
                }
                //Get StudentId use in programming
                if (LoginSuccessHandler!=null)
                {
                    LoginSuccessHandler(strStudentId);
                }
                this.Close();
                //Close Form as Login Success
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            strStudentId = txtAccountId.Text;
            strPassword = txtPassword.Text;
            checkAccountPassword();
            MessageBox.Show("Login fail, try enter...");
        }

        private void chkRememberAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberAccount.Checked)
            {
                if (readFile() == true)
                {
                    DialogResult dr = MessageBox.Show("You are login account old...", "Yes/No question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        checkAccountPassword();
                        MessageBox.Show("Account too old, cannot login.\nYou try a different account...");
                    }
                }
            }
        }

        private void hlblRegisterAccount_Click(object sender, EventArgs e)
        {
            FAccountAdd frmAccountAdd;
            frmAccountAdd = new FAccountAdd();
            frmAccountAdd.GetStudentIdLogin += new FAccountAdd.AccountLoginHandler(frmAccountAdd_EvenGetAccountIdHandler);
            frmAccountAdd.ShowDialog();
        }

        private void frmAccountAdd_EvenGetAccountIdHandler(string strStudentId, string strPassword)
        {
            this.strStudentId = strStudentId;
            this.strPassword = strPassword;
            checkAccountPassword();
        }
    }
}
