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
            this.btnAddScheduleTime = new DevExpress.XtraEditors.SimpleButton();
            this.lblStudentName = new DevExpress.XtraEditors.LabelControl();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.popupMenuAccount = new DevExpress.XtraBars.PopupMenu(this.components);
            this.pbtnEditStudentInfor = new DevExpress.XtraBars.BarButtonItem();
            this.pbtnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.pbtnInitializerSubjectSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.pbtnSignOut = new DevExpress.XtraBars.BarButtonItem();
            this.barManagerAccount = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAddPlan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).BeginInit();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTool.Appearance.Options.UseBackColor = true;
            this.pnlTool.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTool.Controls.Add(this.btnAddPlan);
            this.pnlTool.Controls.Add(this.btnAddScheduleTime);
            this.pnlTool.Controls.Add(this.lblStudentName);
            this.pnlTool.Controls.Add(this.btnHome);
            this.pnlTool.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(835, 85);
            this.pnlTool.TabIndex = 0;
            // 
            // btnAddScheduleTime
            // 
            this.btnAddScheduleTime.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnAddScheduleTime.AppearancePressed.Options.UseBackColor = true;
            this.btnAddScheduleTime.AutoWidthInLayoutControl = true;
            this.btnAddScheduleTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddScheduleTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddScheduleTime.Image = ((System.Drawing.Image)(resources.GetObject("btnAddScheduleTime.Image")));
            this.btnAddScheduleTime.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAddScheduleTime.Location = new System.Drawing.Point(85, 0);
            this.btnAddScheduleTime.Name = "btnAddScheduleTime";
            this.btnAddScheduleTime.Size = new System.Drawing.Size(85, 85);
            this.btnAddScheduleTime.TabIndex = 3;
            this.btnAddScheduleTime.Tag = "Add Schedule Time Table Study";
            this.btnAddScheduleTime.ToolTip = "Add Plan Event";
            this.btnAddScheduleTime.Click += new System.EventHandler(this.btnAddScheduleTime_Click);
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
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // btnHome
            // 
            this.btnHome.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnHome.AppearancePressed.Options.UseBackColor = true;
            this.btnHome.AutoWidthInLayoutControl = true;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 85);
            this.btnHome.TabIndex = 0;
            this.btnHome.Tag = "Page Home Student Study Schedule";
            this.btnHome.ToolTip = "Page Home Student Study Schedule";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // popupMenuAccount
            // 
            this.popupMenuAccount.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pbtnEditStudentInfor),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbtnChangePassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbtnInitializerSubjectSchedule),
            new DevExpress.XtraBars.LinkPersistInfo(this.pbtnSignOut)});
            this.popupMenuAccount.Manager = this.barManagerAccount;
            this.popupMenuAccount.Name = "popupMenuAccount";
            // 
            // pbtnEditStudentInfor
            // 
            this.pbtnEditStudentInfor.Caption = "Edit Student Information";
            this.pbtnEditStudentInfor.Id = 0;
            this.pbtnEditStudentInfor.Name = "pbtnEditStudentInfor";
            this.pbtnEditStudentInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pbtnEditStudentInfor_ItemClick);
            // 
            // pbtnChangePassword
            // 
            this.pbtnChangePassword.Caption = "Change Password Account";
            this.pbtnChangePassword.Id = 1;
            this.pbtnChangePassword.Name = "pbtnChangePassword";
            this.pbtnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pbtnChangePassword_ItemClick);
            // 
            // pbtnInitializerSubjectSchedule
            // 
            this.pbtnInitializerSubjectSchedule.Caption = "Initializer Sujects and Schedule";
            this.pbtnInitializerSubjectSchedule.Id = 2;
            this.pbtnInitializerSubjectSchedule.Name = "pbtnInitializerSubjectSchedule";
            this.pbtnInitializerSubjectSchedule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pbtnInitializerSubjectSchedule_ItemClick);
            // 
            // pbtnSignOut
            // 
            this.pbtnSignOut.Caption = "Sign out";
            this.pbtnSignOut.Id = 3;
            this.pbtnSignOut.Name = "pbtnSignOut";
            this.pbtnSignOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pbtnSignOut_ItemClick);
            // 
            // barManagerAccount
            // 
            this.barManagerAccount.DockControls.Add(this.barDockControlTop);
            this.barManagerAccount.DockControls.Add(this.barDockControlBottom);
            this.barManagerAccount.DockControls.Add(this.barDockControlLeft);
            this.barManagerAccount.DockControls.Add(this.barDockControlRight);
            this.barManagerAccount.Form = this;
            this.barManagerAccount.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.pbtnEditStudentInfor,
            this.pbtnChangePassword,
            this.pbtnInitializerSubjectSchedule,
            this.pbtnSignOut});
            this.barManagerAccount.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Size = new System.Drawing.Size(835, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(835, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.AppearancePressed.BackColor = System.Drawing.Color.Blue;
            this.btnAddPlan.AppearancePressed.Options.UseBackColor = true;
            this.btnAddPlan.AutoWidthInLayoutControl = true;
            this.btnAddPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlan.Image")));
            this.btnAddPlan.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAddPlan.Location = new System.Drawing.Point(170, 0);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(85, 85);
            this.btnAddPlan.TabIndex = 4;
            this.btnAddPlan.Tag = "Add Plan Event";
            this.btnAddPlan.ToolTip = "Add Plan Event";
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 566);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "FMain";
            this.Text = "Student Managerment Study";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Resize += new System.EventHandler(this.FMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTool;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.LabelControl lblStudentName;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarManager barManagerAccount;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem pbtnEditStudentInfor;
        private DevExpress.XtraBars.BarButtonItem pbtnChangePassword;
        private DevExpress.XtraBars.BarButtonItem pbtnInitializerSubjectSchedule;
        private DevExpress.XtraBars.BarButtonItem pbtnSignOut;
        private DevExpress.XtraBars.PopupMenu popupMenuAccount;
        private DevExpress.XtraEditors.SimpleButton btnAddScheduleTime;
        private DevExpress.XtraEditors.SimpleButton btnAddPlan;
    }
}