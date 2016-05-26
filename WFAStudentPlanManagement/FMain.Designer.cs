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
            this.btnAddPlan = new DevExpress.XtraEditors.SimpleButton();
            this.lblStudentName = new DevExpress.XtraEditors.LabelControl();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
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
            this.pnlTool.Controls.Add(this.btnAddPlan);
            this.pnlTool.Controls.Add(this.lblStudentName);
            this.pnlTool.Controls.Add(this.btnHome);
            this.pnlTool.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(835, 85);
            this.pnlTool.TabIndex = 0;
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
            this.btnAddPlan.Location = new System.Drawing.Point(85, 0);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(85, 85);
            this.btnAddPlan.TabIndex = 2;
            this.btnAddPlan.Tag = "Add Plan Event";
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
            this.btnHome.Tag = "Page Home";
            this.btnHome.ToolTip = "Account Sign In";
            this.btnHome.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 491);
            this.Controls.Add(this.pnlTool);
            this.IsMdiContainer = true;
            this.Name = "FMain";
            this.Text = "Student Managerment Study";
            ((System.ComponentModel.ISupportInitialize)(this.pnlTool)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTool;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.LabelControl lblStudentName;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraEditors.SimpleButton btnAddPlan;
    }
}