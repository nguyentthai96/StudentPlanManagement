namespace WFAStudentPlanManagement
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlTool = new DevExpress.XtraEditors.PanelControl();
            this.btnAccount = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblStudentName = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).BeginInit();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTool.Appearance.Options.UseBackColor = true;
            this.pnlTool.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTool.Controls.Add(this.simpleButton1);
            this.pnlTool.Controls.Add(this.lblStudentName);
            this.pnlTool.Controls.Add(this.btnAccount);
            this.pnlTool.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(835, 85);
            this.pnlTool.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnAccount.AppearancePressed.Options.UseBackColor = true;
            this.btnAccount.AutoWidthInLayoutControl = true;
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(85, 85);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Tag = "Sign In";
            this.btnAccount.ToolTip = "Account Sign In";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblStudentName.Location = new System.Drawing.Point(650, 12);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(173, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Hello Nguyễn Thành Thái";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AutoWidthInLayoutControl = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(85, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 85);
            this.simpleButton1.TabIndex = 2;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 491);
            this.Controls.Add(this.pnlTool);
            this.IsMdiContainer = true;
            this.Name = "FMain";
            this.Text = "FMain";
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTool;
        private DevExpress.XtraEditors.SimpleButton btnAccount;
        private DevExpress.XtraEditors.LabelControl lblStudentName;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}