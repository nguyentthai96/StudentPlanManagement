namespace WFAStudentPlanManagement.FormMarks
{
    partial class FSummaryMarks
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
            this.pnlCalculateRight = new DevExpress.XtraEditors.PanelControl();
            this.lblAveragePoints = new DevExpress.XtraEditors.LabelControl();
            this.pnlFill = new DevExpress.XtraEditors.PanelControl();
            this.lblSearch = new DevExpress.XtraEditors.LabelControl();
            this.cmbChkFillSemester = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.splitterControlRight = new DevExpress.XtraEditors.SplitterControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdMarks = new DevExpress.XtraGrid.GridControl();
            this.splGridFill = new DevExpress.XtraEditors.SplitterControl();
            this.lblMarkAverageSemester = new DevExpress.XtraEditors.LabelControl();
            this.lblMarkAverageSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblMarkAverageStudent = new DevExpress.XtraEditors.LabelControl();
            this.txtMarkAverageSubject = new DevExpress.XtraEditors.TextEdit();
            this.txtMarkAverageSemester = new DevExpress.XtraEditors.TextEdit();
            this.txtMarkAverageStudent = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCalculateRight)).BeginInit();
            this.pnlCalculateRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChkFillSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageStudent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCalculateRight
            // 
            this.pnlCalculateRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlCalculateRight.Controls.Add(this.txtMarkAverageStudent);
            this.pnlCalculateRight.Controls.Add(this.txtMarkAverageSemester);
            this.pnlCalculateRight.Controls.Add(this.txtMarkAverageSubject);
            this.pnlCalculateRight.Controls.Add(this.lblMarkAverageStudent);
            this.pnlCalculateRight.Controls.Add(this.lblMarkAverageSubject);
            this.pnlCalculateRight.Controls.Add(this.lblMarkAverageSemester);
            this.pnlCalculateRight.Controls.Add(this.lblAveragePoints);
            this.pnlCalculateRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCalculateRight.Location = new System.Drawing.Point(666, 0);
            this.pnlCalculateRight.Name = "pnlCalculateRight";
            this.pnlCalculateRight.Size = new System.Drawing.Size(256, 510);
            this.pnlCalculateRight.TabIndex = 0;
            this.pnlCalculateRight.Resize += new System.EventHandler(this.pnlCalculateLeft_Resize);
            // 
            // lblAveragePoints
            // 
            this.lblAveragePoints.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.lblAveragePoints.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblAveragePoints.Location = new System.Drawing.Point(28, 49);
            this.lblAveragePoints.Name = "lblAveragePoints";
            this.lblAveragePoints.Size = new System.Drawing.Size(203, 33);
            this.lblAveragePoints.TabIndex = 2;
            this.lblAveragePoints.Text = "Average points";
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.lblSearch);
            this.pnlFill.Controls.Add(this.cmbChkFillSemester);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(661, 80);
            this.pnlFill.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Location = new System.Drawing.Point(299, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Fill Data Marks";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // cmbChkFillSemester
            // 
            this.cmbChkFillSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChkFillSemester.Location = new System.Drawing.Point(430, 20);
            this.cmbChkFillSemester.Name = "cmbChkFillSemester";
            this.cmbChkFillSemester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbChkFillSemester.Size = new System.Drawing.Size(175, 20);
            this.cmbChkFillSemester.TabIndex = 1;
            this.cmbChkFillSemester.EditValueChanged += new System.EventHandler(this.cmbChkFillSemester_EditValueChanged);
            // 
            // splitterControlRight
            // 
            this.splitterControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControlRight.Location = new System.Drawing.Point(661, 0);
            this.splitterControlRight.Name = "splitterControlRight";
            this.splitterControlRight.Size = new System.Drawing.Size(5, 510);
            this.splitterControlRight.TabIndex = 2;
            this.splitterControlRight.TabStop = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdMarks;
            this.gridView1.Name = "gridView1";
            // 
            // grdMarks
            // 
            this.grdMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMarks.Location = new System.Drawing.Point(0, 85);
            this.grdMarks.MainView = this.gridView1;
            this.grdMarks.Name = "grdMarks";
            this.grdMarks.Size = new System.Drawing.Size(661, 425);
            this.grdMarks.TabIndex = 6;
            this.grdMarks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // splGridFill
            // 
            this.splGridFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.splGridFill.Location = new System.Drawing.Point(0, 80);
            this.splGridFill.Name = "splGridFill";
            this.splGridFill.Size = new System.Drawing.Size(661, 5);
            this.splGridFill.TabIndex = 7;
            this.splGridFill.TabStop = false;
            // 
            // lblMarkAverageSemester
            // 
            this.lblMarkAverageSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarkAverageSemester.Location = new System.Drawing.Point(17, 173);
            this.lblMarkAverageSemester.Name = "lblMarkAverageSemester";
            this.lblMarkAverageSemester.Size = new System.Drawing.Size(115, 13);
            this.lblMarkAverageSemester.TabIndex = 3;
            this.lblMarkAverageSemester.Text = "Mark Average Semester";
            // 
            // lblMarkAverageSubject
            // 
            this.lblMarkAverageSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarkAverageSubject.Location = new System.Drawing.Point(17, 121);
            this.lblMarkAverageSubject.Name = "lblMarkAverageSubject";
            this.lblMarkAverageSubject.Size = new System.Drawing.Size(106, 13);
            this.lblMarkAverageSubject.TabIndex = 3;
            this.lblMarkAverageSubject.Text = "Mark Average Subject";
            // 
            // lblMarkAverageStudent
            // 
            this.lblMarkAverageStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarkAverageStudent.Location = new System.Drawing.Point(17, 225);
            this.lblMarkAverageStudent.Name = "lblMarkAverageStudent";
            this.lblMarkAverageStudent.Size = new System.Drawing.Size(108, 13);
            this.lblMarkAverageStudent.TabIndex = 3;
            this.lblMarkAverageStudent.Text = "Mark Average Student";
            // 
            // txtMarkAverageSubject
            // 
            this.txtMarkAverageSubject.Location = new System.Drawing.Point(153, 118);
            this.txtMarkAverageSubject.Name = "txtMarkAverageSubject";
            this.txtMarkAverageSubject.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkAverageSubject.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkAverageSubject.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMarkAverageSubject.Properties.Mask.EditMask = "((1?[0]?))|[0-9][.]\\d{1,2}";
            this.txtMarkAverageSubject.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMarkAverageSubject.Properties.ReadOnly = true;
            this.txtMarkAverageSubject.Size = new System.Drawing.Size(78, 18);
            this.txtMarkAverageSubject.TabIndex = 4;
            // 
            // txtMarkAverageSemester
            // 
            this.txtMarkAverageSemester.Location = new System.Drawing.Point(153, 170);
            this.txtMarkAverageSemester.Name = "txtMarkAverageSemester";
            this.txtMarkAverageSemester.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkAverageSemester.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkAverageSemester.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMarkAverageSemester.Properties.Mask.EditMask = "((1?[0]?))|[0-9][.]\\d{1,2}";
            this.txtMarkAverageSemester.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMarkAverageSemester.Properties.ReadOnly = true;
            this.txtMarkAverageSemester.Size = new System.Drawing.Size(78, 18);
            this.txtMarkAverageSemester.TabIndex = 4;
            // 
            // txtMarkAverageStudent
            // 
            this.txtMarkAverageStudent.Location = new System.Drawing.Point(153, 222);
            this.txtMarkAverageStudent.Name = "txtMarkAverageStudent";
            this.txtMarkAverageStudent.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtMarkAverageStudent.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkAverageStudent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMarkAverageStudent.Properties.Mask.EditMask = "((1?[0]?))|[0-9][.]\\d{1,2}";
            this.txtMarkAverageStudent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMarkAverageStudent.Properties.ReadOnly = true;
            this.txtMarkAverageStudent.Size = new System.Drawing.Size(78, 18);
            this.txtMarkAverageStudent.TabIndex = 4;
            // 
            // FSummaryMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 510);
            this.Controls.Add(this.grdMarks);
            this.Controls.Add(this.splGridFill);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.splitterControlRight);
            this.Controls.Add(this.pnlCalculateRight);
            this.Name = "FSummaryMarks";
            this.Text = "FSummaryMarks";
            this.Load += new System.EventHandler(this.FSummaryMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCalculateRight)).EndInit();
            this.pnlCalculateRight.ResumeLayout(false);
            this.pnlCalculateRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChkFillSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkAverageStudent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlCalculateRight;
        private DevExpress.XtraEditors.PanelControl pnlFill;
        private DevExpress.XtraEditors.SplitterControl splitterControlRight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdMarks;
        private DevExpress.XtraEditors.SplitterControl splGridFill;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbChkFillSemester;
        private DevExpress.XtraEditors.LabelControl lblAveragePoints;
        private DevExpress.XtraEditors.LabelControl lblSearch;
        private DevExpress.XtraEditors.TextEdit txtMarkAverageStudent;
        private DevExpress.XtraEditors.TextEdit txtMarkAverageSemester;
        private DevExpress.XtraEditors.TextEdit txtMarkAverageSubject;
        private DevExpress.XtraEditors.LabelControl lblMarkAverageStudent;
        private DevExpress.XtraEditors.LabelControl lblMarkAverageSubject;
        private DevExpress.XtraEditors.LabelControl lblMarkAverageSemester;
    }
}