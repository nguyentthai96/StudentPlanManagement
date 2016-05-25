namespace WFAStudentPlanManagement.FormPlan
{
    partial class FPlanAdd
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
            this.lblPlanTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblPrensentationDate = new DevExpress.XtraEditors.LabelControl();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblRenmindDay = new DevExpress.XtraEditors.LabelControl();
            this.lblContextPlan = new DevExpress.XtraEditors.LabelControl();
            this.lblDescribe = new DevExpress.XtraEditors.LabelControl();
            this.dtRemindDay = new DevExpress.XtraEditors.DateEdit();
            this.txtPlanTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtContextPlan = new DevExpress.XtraEditors.MemoEdit();
            this.txtDescribe = new DevExpress.XtraEditors.MemoEdit();
            this.tmStart = new DevExpress.XtraEditors.TimeEdit();
            this.tmEnd = new DevExpress.XtraEditors.TimeEdit();
            this.lblTimeTo = new DevExpress.XtraEditors.LabelControl();
            this.txtDateStart = new DevExpress.XtraEditors.TextEdit();
            this.txtDateEnd = new DevExpress.XtraEditors.TextEdit();
            this.lblDateTo = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtRemindDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRemindDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContextPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescribe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlanTitle
            // 
            this.lblPlanTitle.Location = new System.Drawing.Point(27, 31);
            this.lblPlanTitle.Name = "lblPlanTitle";
            this.lblPlanTitle.Size = new System.Drawing.Size(43, 13);
            this.lblPlanTitle.TabIndex = 0;
            this.lblPlanTitle.Text = "Plan Title";
            // 
            // lblPrensentationDate
            // 
            this.lblPrensentationDate.Location = new System.Drawing.Point(27, 73);
            this.lblPrensentationDate.Name = "lblPrensentationDate";
            this.lblPrensentationDate.Size = new System.Drawing.Size(87, 13);
            this.lblPrensentationDate.TabIndex = 0;
            this.lblPrensentationDate.Text = "Presentation Date";
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(92, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(22, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // lblRenmindDay
            // 
            this.lblRenmindDay.Location = new System.Drawing.Point(27, 157);
            this.lblRenmindDay.Name = "lblRenmindDay";
            this.lblRenmindDay.Size = new System.Drawing.Size(57, 13);
            this.lblRenmindDay.TabIndex = 0;
            this.lblRenmindDay.Text = "Remind Day";
            // 
            // lblContextPlan
            // 
            this.lblContextPlan.Location = new System.Drawing.Point(27, 199);
            this.lblContextPlan.Name = "lblContextPlan";
            this.lblContextPlan.Size = new System.Drawing.Size(62, 13);
            this.lblContextPlan.TabIndex = 0;
            this.lblContextPlan.Text = "Context Plan";
            // 
            // lblDescribe
            // 
            this.lblDescribe.Location = new System.Drawing.Point(27, 250);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(41, 13);
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Describe";
            // 
            // dtRemindDay
            // 
            this.dtRemindDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtRemindDay.EditValue = null;
            this.dtRemindDay.Location = new System.Drawing.Point(145, 154);
            this.dtRemindDay.Name = "dtRemindDay";
            this.dtRemindDay.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.dtRemindDay.Properties.Appearance.Options.UseBackColor = true;
            this.dtRemindDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtRemindDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtRemindDay.Size = new System.Drawing.Size(257, 20);
            this.dtRemindDay.TabIndex = 6;
            this.dtRemindDay.Enter += new System.EventHandler(this.dtRemindDay_Enter);
            this.dtRemindDay.Leave += new System.EventHandler(this.dtRemindDay_Leave);
            // 
            // txtPlanTitle
            // 
            this.txtPlanTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanTitle.Location = new System.Drawing.Point(145, 28);
            this.txtPlanTitle.Name = "txtPlanTitle";
            this.txtPlanTitle.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlanTitle.Properties.Appearance.Options.UseBackColor = true;
            this.txtPlanTitle.Size = new System.Drawing.Size(257, 20);
            this.txtPlanTitle.TabIndex = 1;
            // 
            // txtContextPlan
            // 
            this.txtContextPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContextPlan.Location = new System.Drawing.Point(145, 197);
            this.txtContextPlan.Name = "txtContextPlan";
            this.txtContextPlan.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtContextPlan.Properties.Appearance.Options.UseBackColor = true;
            this.txtContextPlan.Size = new System.Drawing.Size(257, 29);
            this.txtContextPlan.TabIndex = 7;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescribe.Location = new System.Drawing.Point(145, 248);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescribe.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescribe.Size = new System.Drawing.Size(257, 29);
            this.txtDescribe.TabIndex = 8;
            // 
            // tmStart
            // 
            this.tmStart.EditValue = new System.DateTime(2016, 5, 25, 0, 0, 0, 0);
            this.tmStart.Location = new System.Drawing.Point(145, 115);
            this.tmStart.Name = "tmStart";
            this.tmStart.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tmStart.Properties.Appearance.Options.UseBackColor = true;
            this.tmStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmStart.Size = new System.Drawing.Size(100, 20);
            this.tmStart.TabIndex = 4;
            // 
            // tmEnd
            // 
            this.tmEnd.EditValue = new System.DateTime(2016, 5, 25, 0, 0, 0, 0);
            this.tmEnd.Location = new System.Drawing.Point(302, 115);
            this.tmEnd.Name = "tmEnd";
            this.tmEnd.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.tmEnd.Properties.Appearance.Options.UseBackColor = true;
            this.tmEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmEnd.Size = new System.Drawing.Size(100, 20);
            this.tmEnd.TabIndex = 5;
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimeTo.Location = new System.Drawing.Point(263, 118);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(10, 13);
            this.lblTimeTo.TabIndex = 0;
            this.lblTimeTo.Text = "to";
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(145, 70);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateStart.Properties.Appearance.Options.UseBackColor = true;
            this.txtDateStart.Properties.DisplayFormat.FormatString = "d";
            this.txtDateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateStart.Properties.EditFormat.FormatString = "d";
            this.txtDateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateStart.Properties.Mask.BeepOnError = true;
            this.txtDateStart.Properties.Mask.EditMask = "d";
            this.txtDateStart.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateStart.Size = new System.Drawing.Size(100, 20);
            this.txtDateStart.TabIndex = 2;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(302, 70);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateEnd.Properties.Appearance.Options.UseBackColor = true;
            this.txtDateEnd.Properties.DisplayFormat.FormatString = "d";
            this.txtDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateEnd.Properties.EditFormat.FormatString = "d";
            this.txtDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateEnd.Properties.Mask.BeepOnError = true;
            this.txtDateEnd.Properties.Mask.EditMask = "d";
            this.txtDateEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateEnd.Size = new System.Drawing.Size(100, 20);
            this.txtDateEnd.TabIndex = 3;
            // 
            // lblDateTo
            // 
            this.lblDateTo.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateTo.Location = new System.Drawing.Point(263, 73);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(10, 13);
            this.lblDateTo.TabIndex = 0;
            this.lblDateTo.Text = "to";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(211, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(327, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FPlanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 373);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.tmEnd);
            this.Controls.Add(this.tmStart);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.txtContextPlan);
            this.Controls.Add(this.txtPlanTitle);
            this.Controls.Add(this.dtRemindDay);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblContextPlan);
            this.Controls.Add(this.lblRenmindDay);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblTimeTo);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPrensentationDate);
            this.Controls.Add(this.lblPlanTitle);
            this.Name = "FPlanAdd";
            this.Text = "Plan New";
            ((System.ComponentModel.ISupportInitialize)(this.dtRemindDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRemindDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContextPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescribe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblPlanTitle;
        private DevExpress.XtraEditors.LabelControl lblPrensentationDate;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl lblRenmindDay;
        private DevExpress.XtraEditors.LabelControl lblContextPlan;
        private DevExpress.XtraEditors.LabelControl lblDescribe;
        private DevExpress.XtraEditors.DateEdit dtRemindDay;
        private DevExpress.XtraEditors.TextEdit txtPlanTitle;
        private DevExpress.XtraEditors.MemoEdit txtContextPlan;
        private DevExpress.XtraEditors.MemoEdit txtDescribe;
        private DevExpress.XtraEditors.TimeEdit tmStart;
        private DevExpress.XtraEditors.TimeEdit tmEnd;
        private DevExpress.XtraEditors.LabelControl lblTimeTo;
        private DevExpress.XtraEditors.TextEdit txtDateStart;
        private DevExpress.XtraEditors.TextEdit txtDateEnd;
        private DevExpress.XtraEditors.LabelControl lblDateTo;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}