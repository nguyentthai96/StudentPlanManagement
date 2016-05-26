namespace WFAStudentPlanManagement.FormSchedules
{
    partial class FScheduleRegisterSubject
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
            this.cmbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.cmbInstructor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblInstructor = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberOfCreadit = new DevExpress.XtraEditors.TextEdit();
            this.lblNumberOfCreadit = new DevExpress.XtraEditors.LabelControl();
            this.lblNuberLessonOfDay = new DevExpress.XtraEditors.LabelControl();
            this.txtNuberLessonOfDay = new DevExpress.XtraEditors.TextEdit();
            this.lblDayStudy = new DevExpress.XtraEditors.LabelControl();
            this.weekDayStudy = new DevExpress.XtraScheduler.UI.WeekDaysCheckEdit();
            this.lblTimeStart = new DevExpress.XtraEditors.LabelControl();
            this.tmeStart = new DevExpress.XtraEditors.TimeEdit();
            this.lblTimeEnd = new DevExpress.XtraEditors.LabelControl();
            this.tmeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.lblClassRom = new DevExpress.XtraEditors.LabelControl();
            this.txtClassRom = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblScheduleTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtScheduleTitle = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstructor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfCreadit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuberLessonOfDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDayStudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassRom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScheduleTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSubject
            // 
            this.cmbSubject.Location = new System.Drawing.Point(100, 22);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSubject.Properties.Appearance.Options.UseBackColor = true;
            this.cmbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubject.Size = new System.Drawing.Size(127, 20);
            this.cmbSubject.TabIndex = 0;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(22, 25);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(36, 13);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInstructor.Location = new System.Drawing.Point(100, 117);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.cmbInstructor.Properties.Appearance.Options.UseBackColor = true;
            this.cmbInstructor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInstructor.Size = new System.Drawing.Size(328, 20);
            this.cmbInstructor.TabIndex = 0;
            // 
            // lblInstructor
            // 
            this.lblInstructor.Location = new System.Drawing.Point(22, 120);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(48, 13);
            this.lblInstructor.TabIndex = 1;
            this.lblInstructor.Text = "Instructor";
            // 
            // txtNumberOfCreadit
            // 
            this.txtNumberOfCreadit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfCreadit.Location = new System.Drawing.Point(373, 22);
            this.txtNumberOfCreadit.Name = "txtNumberOfCreadit";
            this.txtNumberOfCreadit.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumberOfCreadit.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumberOfCreadit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtNumberOfCreadit.Properties.ReadOnly = true;
            this.txtNumberOfCreadit.Size = new System.Drawing.Size(55, 18);
            this.txtNumberOfCreadit.TabIndex = 2;
            // 
            // lblNumberOfCreadit
            // 
            this.lblNumberOfCreadit.Location = new System.Drawing.Point(260, 25);
            this.lblNumberOfCreadit.Name = "lblNumberOfCreadit";
            this.lblNumberOfCreadit.Size = new System.Drawing.Size(82, 13);
            this.lblNumberOfCreadit.TabIndex = 3;
            this.lblNumberOfCreadit.Text = "Number of Credit";
            // 
            // lblNuberLessonOfDay
            // 
            this.lblNuberLessonOfDay.Location = new System.Drawing.Point(260, 72);
            this.lblNuberLessonOfDay.Name = "lblNuberLessonOfDay";
            this.lblNuberLessonOfDay.Size = new System.Drawing.Size(107, 13);
            this.lblNuberLessonOfDay.TabIndex = 3;
            this.lblNuberLessonOfDay.Text = "Number Lesson of day";
            // 
            // txtNuberLessonOfDay
            // 
            this.txtNuberLessonOfDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuberLessonOfDay.Location = new System.Drawing.Point(373, 69);
            this.txtNuberLessonOfDay.Name = "txtNuberLessonOfDay";
            this.txtNuberLessonOfDay.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtNuberLessonOfDay.Properties.Appearance.Options.UseBackColor = true;
            this.txtNuberLessonOfDay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtNuberLessonOfDay.Properties.ReadOnly = true;
            this.txtNuberLessonOfDay.Size = new System.Drawing.Size(55, 18);
            this.txtNuberLessonOfDay.TabIndex = 2;
            // 
            // lblDayStudy
            // 
            this.lblDayStudy.Location = new System.Drawing.Point(22, 230);
            this.lblDayStudy.Name = "lblDayStudy";
            this.lblDayStudy.Size = new System.Drawing.Size(50, 13);
            this.lblDayStudy.TabIndex = 5;
            this.lblDayStudy.Text = "Day Study";
            // 
            // weekDayStudy
            // 
            this.weekDayStudy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weekDayStudy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weekDayStudy.Appearance.Options.UseBackColor = true;
            this.weekDayStudy.Location = new System.Drawing.Point(100, 230);
            this.weekDayStudy.Name = "weekDayStudy";
            this.weekDayStudy.Size = new System.Drawing.Size(328, 60);
            this.weekDayStudy.TabIndex = 6;
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.Location = new System.Drawing.Point(22, 197);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(49, 13);
            this.lblTimeStart.TabIndex = 7;
            this.lblTimeStart.Text = "Time Start";
            // 
            // tmeStart
            // 
            this.tmeStart.EditValue = new System.DateTime(2016, 5, 24, 0, 0, 0, 0);
            this.tmeStart.Location = new System.Drawing.Point(100, 194);
            this.tmeStart.Name = "tmeStart";
            this.tmeStart.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tmeStart.Properties.Appearance.Options.UseBackColor = true;
            this.tmeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeStart.Size = new System.Drawing.Size(100, 20);
            this.tmeStart.TabIndex = 8;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeEnd.Location = new System.Drawing.Point(260, 197);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(43, 13);
            this.lblTimeEnd.TabIndex = 9;
            this.lblTimeEnd.Text = "Time End";
            // 
            // tmeEnd
            // 
            this.tmeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmeEnd.EditValue = new System.DateTime(2016, 5, 24, 0, 0, 0, 0);
            this.tmeEnd.Location = new System.Drawing.Point(328, 194);
            this.tmeEnd.Name = "tmeEnd";
            this.tmeEnd.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tmeEnd.Properties.Appearance.Options.UseBackColor = true;
            this.tmeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeEnd.Size = new System.Drawing.Size(100, 20);
            this.tmeEnd.TabIndex = 8;
            // 
            // lblClassRom
            // 
            this.lblClassRom.Location = new System.Drawing.Point(22, 301);
            this.lblClassRom.Name = "lblClassRom";
            this.lblClassRom.Size = new System.Drawing.Size(46, 13);
            this.lblClassRom.TabIndex = 11;
            this.lblClassRom.Text = "ClassRom";
            // 
            // txtClassRom
            // 
            this.txtClassRom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassRom.Location = new System.Drawing.Point(100, 298);
            this.txtClassRom.Name = "txtClassRom";
            this.txtClassRom.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtClassRom.Properties.Appearance.Options.UseBackColor = true;
            this.txtClassRom.Size = new System.Drawing.Size(328, 20);
            this.txtClassRom.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblScheduleTitle
            // 
            this.lblScheduleTitle.Location = new System.Drawing.Point(22, 159);
            this.lblScheduleTitle.Name = "lblScheduleTitle";
            this.lblScheduleTitle.Size = new System.Drawing.Size(66, 13);
            this.lblScheduleTitle.TabIndex = 14;
            this.lblScheduleTitle.Text = "Schedule Title";
            // 
            // txtScheduleTitle
            // 
            this.txtScheduleTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScheduleTitle.EditValue = "";
            this.txtScheduleTitle.Location = new System.Drawing.Point(100, 156);
            this.txtScheduleTitle.Name = "txtScheduleTitle";
            this.txtScheduleTitle.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtScheduleTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtScheduleTitle.Size = new System.Drawing.Size(328, 20);
            this.txtScheduleTitle.TabIndex = 13;
            // 
            // FScheduleRegisterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 388);
            this.Controls.Add(this.lblScheduleTitle);
            this.Controls.Add(this.txtScheduleTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblClassRom);
            this.Controls.Add(this.txtClassRom);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.tmeEnd);
            this.Controls.Add(this.tmeStart);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.weekDayStudy);
            this.Controls.Add(this.lblDayStudy);
            this.Controls.Add(this.lblNuberLessonOfDay);
            this.Controls.Add(this.lblNumberOfCreadit);
            this.Controls.Add(this.txtNuberLessonOfDay);
            this.Controls.Add(this.txtNumberOfCreadit);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubject);
            this.Name = "FScheduleRegisterSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Schedule Subject";
            this.Load += new System.EventHandler(this.FScheduleRegisterSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInstructor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfCreadit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuberLessonOfDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDayStudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClassRom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScheduleTitle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbSubject;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInstructor;
        private DevExpress.XtraEditors.LabelControl lblInstructor;
        private DevExpress.XtraEditors.TextEdit txtNumberOfCreadit;
        private DevExpress.XtraEditors.LabelControl lblNumberOfCreadit;
        private DevExpress.XtraEditors.LabelControl lblNuberLessonOfDay;
        private DevExpress.XtraEditors.TextEdit txtNuberLessonOfDay;
        private DevExpress.XtraEditors.LabelControl lblDayStudy;
        private DevExpress.XtraScheduler.UI.WeekDaysCheckEdit weekDayStudy;
        private DevExpress.XtraEditors.LabelControl lblTimeStart;
        private DevExpress.XtraEditors.TimeEdit tmeStart;
        private DevExpress.XtraEditors.LabelControl lblTimeEnd;
        private DevExpress.XtraEditors.TimeEdit tmeEnd;
        private DevExpress.XtraEditors.LabelControl lblClassRom;
        private DevExpress.XtraEditors.TextEdit txtClassRom;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblScheduleTitle;
        private DevExpress.XtraEditors.TextEdit txtScheduleTitle;
    }
}