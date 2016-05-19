namespace WFAStudentPlanManagement
{
    partial class FStudentInformationLoad
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
            this.txtGenders = new DevExpress.XtraEditors.TextEdit();
            this.txtDateOfBirth = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(150, 21);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblGenders
            // 
            this.lblGenders.Location = new System.Drawing.Point(150, 64);
            this.lblGenders.Name = "lblGenders";
            this.lblGenders.Size = new System.Drawing.Size(40, 13);
            this.lblGenders.TabIndex = 0;
            this.lblGenders.Text = "Genders";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(150, 109);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(61, 13);
            this.lblDateOfBirth.TabIndex = 0;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(150, 150);
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
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStudentName.Location = new System.Drawing.Point(235, 18);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentName.Properties.Appearance.Options.UseBackColor = true;
            this.txtStudentName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStudentName.Properties.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(178, 18);
            this.txtStudentName.TabIndex = 2;
            // 
            // txtGenders
            // 
            this.txtGenders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenders.EditValue = "";
            this.txtGenders.Location = new System.Drawing.Point(235, 61);
            this.txtGenders.Name = "txtGenders";
            this.txtGenders.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtGenders.Properties.Appearance.Options.UseBackColor = true;
            this.txtGenders.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtGenders.Properties.ReadOnly = true;
            this.txtGenders.Size = new System.Drawing.Size(178, 18);
            this.txtGenders.TabIndex = 2;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateOfBirth.Location = new System.Drawing.Point(235, 106);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateOfBirth.Properties.Appearance.Options.UseBackColor = true;
            this.txtDateOfBirth.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDateOfBirth.Properties.Mask.BeepOnError = true;
            this.txtDateOfBirth.Properties.Mask.EditMask = "d";
            this.txtDateOfBirth.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDateOfBirth.Properties.ReadOnly = true;
            this.txtDateOfBirth.Size = new System.Drawing.Size(178, 18);
            this.txtDateOfBirth.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(235, 148);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(178, 37);
            this.txtAddress.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(338, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.txtGenders);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.picStudentImage);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblGenders);
            this.Controls.Add(this.lblStudentName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FStudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.FStudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStudentImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtGenders;
        private DevExpress.XtraEditors.TextEdit txtDateOfBirth;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}

