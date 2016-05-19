namespace WFAStudentPlanManagement
{
    partial class FStudentInformationAdd
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
            this.lblStudentName = new DevExpress.XtraEditors.LabelControl();
            this.lblGenders = new DevExpress.XtraEditors.LabelControl();
            this.lblDateOfBirth = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.picStudentImage = new DevExpress.XtraEditors.PictureEdit();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.txtDateOfBirth = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblStudenId = new DevExpress.XtraEditors.LabelControl();
            this.txtStudenId = new DevExpress.XtraEditors.TextEdit();
            this.rdoGenders = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudenId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoGenders.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(150, 65);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblGenders
            // 
            this.lblGenders.Location = new System.Drawing.Point(150, 107);
            this.lblGenders.Name = "lblGenders";
            this.lblGenders.Size = new System.Drawing.Size(40, 13);
            this.lblGenders.TabIndex = 0;
            this.lblGenders.Text = "Genders";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(150, 149);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(61, 13);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(150, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // picStudentImage
            // 
            this.picStudentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picStudentImage.Location = new System.Drawing.Point(21, 21);
            this.picStudentImage.Name = "picStudentImage";
            this.picStudentImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picStudentImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picStudentImage.Size = new System.Drawing.Size(114, 142);
            this.picStudentImage.TabIndex = 1;
            this.picStudentImage.Click += new System.EventHandler(this.picStudentImage_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.Location = new System.Drawing.Point(235, 61);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentName.Properties.Appearance.Options.UseBackColor = true;
            this.txtStudentName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtStudentName.Size = new System.Drawing.Size(178, 22);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateOfBirth.Location = new System.Drawing.Point(235, 149);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateOfBirth.Properties.Appearance.Options.UseBackColor = true;
            this.txtDateOfBirth.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDateOfBirth.Properties.DisplayFormat.FormatString = "dd/mm/yyyy";
            this.txtDateOfBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateOfBirth.Properties.EditFormat.FormatString = "dd/mm/yyyy";
            this.txtDateOfBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDateOfBirth.Properties.Mask.BeepOnError = true;
            this.txtDateOfBirth.Properties.Mask.EditMask = "dd/mm/yyyy";
            this.txtDateOfBirth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateOfBirth.Size = new System.Drawing.Size(178, 22);
            this.txtDateOfBirth.TabIndex = 4;
            this.txtDateOfBirth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDateOfBirth_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(235, 191);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtAddress.Size = new System.Drawing.Size(178, 37);
            this.txtAddress.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(338, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(235, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStudenId
            // 
            this.lblStudenId.Location = new System.Drawing.Point(150, 23);
            this.lblStudenId.Name = "lblStudenId";
            this.lblStudenId.Size = new System.Drawing.Size(52, 13);
            this.lblStudenId.TabIndex = 0;
            this.lblStudenId.Text = "Student ID";
            // 
            // txtStudenId
            // 
            this.txtStudenId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudenId.Enabled = false;
            this.txtStudenId.Location = new System.Drawing.Point(235, 21);
            this.txtStudenId.Name = "txtStudenId";
            this.txtStudenId.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudenId.Properties.Appearance.Options.UseBackColor = true;
            this.txtStudenId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtStudenId.Size = new System.Drawing.Size(178, 22);
            this.txtStudenId.TabIndex = 2;
            // 
            // rdoGenders
            // 
            this.rdoGenders.Location = new System.Drawing.Point(235, 100);
            this.rdoGenders.Name = "rdoGenders";
            this.rdoGenders.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.rdoGenders.Properties.Appearance.Options.UseBackColor = true;
            this.rdoGenders.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoGenders.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rdoGenders.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Male"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Female")});
            this.rdoGenders.Size = new System.Drawing.Size(178, 28);
            this.rdoGenders.TabIndex = 7;
            this.rdoGenders.SelectedIndexChanged += new System.EventHandler(this.rdoGenders_SelectedIndexChanged);
            // 
            // FStudentInformationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.rdoGenders);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtStudenId);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.picStudentImage);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblStudenId);
            this.Controls.Add(this.lblGenders);
            this.Controls.Add(this.lblStudentName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FStudentInformationAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Student Information";
            this.Load += new System.EventHandler(this.FStudentInformationAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudenId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoGenders.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblStudentName;
        private DevExpress.XtraEditors.LabelControl lblGenders;
        private DevExpress.XtraEditors.LabelControl lblDateOfBirth;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.PictureEdit picStudentImage;
        private DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraEditors.TextEdit txtDateOfBirth;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblStudenId;
        private DevExpress.XtraEditors.TextEdit txtStudenId;
        private DevExpress.XtraEditors.RadioGroup rdoGenders;
    }
}

