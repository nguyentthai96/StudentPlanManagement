namespace WFAStudentPlanManagement.FormMarks
{
    partial class FMarkAdd
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
            this.lblMarkScore = new DevExpress.XtraEditors.LabelControl();
            this.txtMarkScore = new DevExpress.XtraEditors.TextEdit();
            this.lblMarkRatio = new DevExpress.XtraEditors.LabelControl();
            this.dtDayOfMark = new DevExpress.XtraEditors.DateEdit();
            this.lblDayOfMark = new DevExpress.XtraEditors.LabelControl();
            this.lblMarkDescrible = new DevExpress.XtraEditors.LabelControl();
            this.txtMarkDescrible = new DevExpress.XtraEditors.MemoEdit();
            this.txtMarkRatio = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.cmbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDayOfMark.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDayOfMark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkDescrible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarkScore
            // 
            this.lblMarkScore.Location = new System.Drawing.Point(19, 82);
            this.lblMarkScore.Name = "lblMarkScore";
            this.lblMarkScore.Size = new System.Drawing.Size(53, 13);
            this.lblMarkScore.TabIndex = 0;
            this.lblMarkScore.Text = "Mark Score";
            // 
            // txtMarkScore
            // 
            this.txtMarkScore.Location = new System.Drawing.Point(99, 79);
            this.txtMarkScore.Name = "txtMarkScore";
            this.txtMarkScore.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkScore.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkScore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMarkScore.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMarkScore.Properties.Mask.BeepOnError = true;
            this.txtMarkScore.Properties.Mask.EditMask = "((1?[0]?))|[0-9][.]\\d{1,2}";
            this.txtMarkScore.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMarkScore.Size = new System.Drawing.Size(67, 20);
            this.txtMarkScore.TabIndex = 2;
            // 
            // lblMarkRatio
            // 
            this.lblMarkRatio.Location = new System.Drawing.Point(201, 82);
            this.lblMarkRatio.Name = "lblMarkRatio";
            this.lblMarkRatio.Size = new System.Drawing.Size(51, 13);
            this.lblMarkRatio.TabIndex = 0;
            this.lblMarkRatio.Text = "Mark Ratio";
            // 
            // dtDayOfMark
            // 
            this.dtDayOfMark.EditValue = null;
            this.dtDayOfMark.Location = new System.Drawing.Point(99, 125);
            this.dtDayOfMark.Name = "dtDayOfMark";
            this.dtDayOfMark.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.dtDayOfMark.Properties.Appearance.Options.UseBackColor = true;
            this.dtDayOfMark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDayOfMark.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDayOfMark.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtDayOfMark.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtDayOfMark.Size = new System.Drawing.Size(226, 20);
            this.dtDayOfMark.TabIndex = 4;
            // 
            // lblDayOfMark
            // 
            this.lblDayOfMark.Location = new System.Drawing.Point(19, 128);
            this.lblDayOfMark.Name = "lblDayOfMark";
            this.lblDayOfMark.Size = new System.Drawing.Size(58, 13);
            this.lblDayOfMark.TabIndex = 0;
            this.lblDayOfMark.Text = "Day of Mark";
            // 
            // lblMarkDescrible
            // 
            this.lblMarkDescrible.Location = new System.Drawing.Point(19, 174);
            this.lblMarkDescrible.Name = "lblMarkDescrible";
            this.lblMarkDescrible.Size = new System.Drawing.Size(69, 13);
            this.lblMarkDescrible.TabIndex = 0;
            this.lblMarkDescrible.Text = "Mark Describle";
            // 
            // txtMarkDescrible
            // 
            this.txtMarkDescrible.Location = new System.Drawing.Point(99, 172);
            this.txtMarkDescrible.Name = "txtMarkDescrible";
            this.txtMarkDescrible.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkDescrible.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkDescrible.Size = new System.Drawing.Size(226, 60);
            this.txtMarkDescrible.TabIndex = 5;
            // 
            // txtMarkRatio
            // 
            this.txtMarkRatio.Location = new System.Drawing.Point(258, 79);
            this.txtMarkRatio.Name = "txtMarkRatio";
            this.txtMarkRatio.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkRatio.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkRatio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMarkRatio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMarkRatio.Properties.Mask.BeepOnError = true;
            this.txtMarkRatio.Properties.Mask.EditMask = "(\\d{1,2})|1?[0][0]";
            this.txtMarkRatio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMarkRatio.Size = new System.Drawing.Size(67, 20);
            this.txtMarkRatio.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(19, 36);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(53, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Mark Score";
            // 
            // cmbSubject
            // 
            this.cmbSubject.EditValue = "You are select subject...";
            this.cmbSubject.Location = new System.Drawing.Point(99, 33);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSubject.Properties.Appearance.BackColor2 = System.Drawing.SystemColors.Control;
            this.cmbSubject.Properties.Appearance.BorderColor = System.Drawing.SystemColors.Control;
            this.cmbSubject.Properties.Appearance.Options.UseBackColor = true;
            this.cmbSubject.Properties.Appearance.Options.UseBorderColor = true;
            this.cmbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubject.Size = new System.Drawing.Size(226, 20);
            this.cmbSubject.TabIndex = 1;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // FMarkAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 318);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMarkDescrible);
            this.Controls.Add(this.dtDayOfMark);
            this.Controls.Add(this.txtMarkRatio);
            this.Controls.Add(this.txtMarkScore);
            this.Controls.Add(this.lblMarkDescrible);
            this.Controls.Add(this.lblDayOfMark);
            this.Controls.Add(this.lblMarkRatio);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblMarkScore);
            this.Name = "FMarkAdd";
            this.Text = "FMarkAdd";
            this.Load += new System.EventHandler(this.FMarkAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDayOfMark.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDayOfMark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkDescrible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMarkScore;
        private DevExpress.XtraEditors.TextEdit txtMarkScore;
        private DevExpress.XtraEditors.LabelControl lblMarkRatio;
        private DevExpress.XtraEditors.DateEdit dtDayOfMark;
        private DevExpress.XtraEditors.LabelControl lblDayOfMark;
        private DevExpress.XtraEditors.LabelControl lblMarkDescrible;
        private DevExpress.XtraEditors.MemoEdit txtMarkDescrible;
        private DevExpress.XtraEditors.TextEdit txtMarkRatio;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSubject;
    }
}