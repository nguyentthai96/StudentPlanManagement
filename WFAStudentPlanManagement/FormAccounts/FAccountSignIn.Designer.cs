namespace WFAStudentPlanManagement.FormAccounts
{
    partial class FAccountSignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlEmpty = new DevExpress.XtraEditors.PanelControl();
            this.lblHelo = new DevExpress.XtraEditors.LabelControl();
            this.pnlLogin = new DevExpress.XtraEditors.PanelControl();
            this.hlblRegisterAccount = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chkRememberAccount = new DevExpress.XtraEditors.CheckEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmpty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEmpty.Location = new System.Drawing.Point(0, 0);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(671, 59);
            this.pnlEmpty.TabIndex = 1;
            // 
            // lblHelo
            // 
            this.lblHelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelo.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.lblHelo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblHelo.AutoEllipsis = true;
            this.lblHelo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHelo.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblHelo.Location = new System.Drawing.Point(0, 65);
            this.lblHelo.Name = "lblHelo";
            this.lblHelo.Size = new System.Drawing.Size(855, 45);
            this.lblHelo.TabIndex = 3;
            this.lblHelo.Text = "Hello, to use the software you must login account....";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlLogin.Controls.Add(this.hlblRegisterAccount);
            this.pnlLogin.Controls.Add(this.chkRememberAccount);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtAccountId);
            this.pnlLogin.Location = new System.Drawing.Point(0, 124);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(671, 291);
            this.pnlLogin.TabIndex = 7;
            // 
            // hlblRegisterAccount
            // 
            this.hlblRegisterAccount.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.hlblRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hlblRegisterAccount.Location = new System.Drawing.Point(368, 129);
            this.hlblRegisterAccount.Name = "hlblRegisterAccount";
            this.hlblRegisterAccount.Size = new System.Drawing.Size(96, 16);
            this.hlblRegisterAccount.TabIndex = 4;
            this.hlblRegisterAccount.Text = "Register Account";
            this.hlblRegisterAccount.Click += new System.EventHandler(this.hlblRegisterAccount_Click);
            // 
            // chkRememberAccount
            // 
            this.chkRememberAccount.EditValue = true;
            this.chkRememberAccount.Location = new System.Drawing.Point(206, 127);
            this.chkRememberAccount.Name = "chkRememberAccount";
            this.chkRememberAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkRememberAccount.Properties.Appearance.Options.UseFont = true;
            this.chkRememberAccount.Properties.Caption = "Remember Account";
            this.chkRememberAccount.Size = new System.Drawing.Size(145, 20);
            this.chkRememberAccount.TabIndex = 5;
            this.chkRememberAccount.CheckedChanged += new System.EventHandler(this.chkRememberAccount_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(206, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 32);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "Password";
            this.txtPassword.Location = new System.Drawing.Point(206, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Size = new System.Drawing.Size(258, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtAccountId
            // 
            this.txtAccountId.EditValue = "Account Id";
            this.txtAccountId.Location = new System.Drawing.Point(206, 54);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAccountId.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccountId.Properties.Appearance.Options.UseFont = true;
            this.txtAccountId.Properties.Appearance.Options.UseForeColor = true;
            this.txtAccountId.Size = new System.Drawing.Size(258, 22);
            this.txtAccountId.TabIndex = 2;
            this.txtAccountId.Enter += new System.EventHandler(this.txtAccountId_Enter);
            this.txtAccountId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAccountId_KeyUp);
            this.txtAccountId.Leave += new System.EventHandler(this.txtAccountId_Leave);
            // 
            // FAccountSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 400);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblHelo);
            this.Controls.Add(this.pnlEmpty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAccountSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign In Account";
            this.Load += new System.EventHandler(this.FAccountSignIn_Load);
            this.Resize += new System.EventHandler(this.FAccountSignIn_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRememberAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlEmpty;
        private DevExpress.XtraEditors.LabelControl lblHelo;
        private DevExpress.XtraEditors.PanelControl pnlLogin;
        private DevExpress.XtraEditors.HyperlinkLabelControl hlblRegisterAccount;
        private DevExpress.XtraEditors.CheckEdit chkRememberAccount;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtAccountId;
    }
}