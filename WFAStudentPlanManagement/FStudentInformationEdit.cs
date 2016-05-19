using StudentPlanManagementData.Models;
using StudentPlanManagementBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WFAStudentPlanManagement
{
    public partial class FStudentInformationEdit : Form
    {
        private CStudentEntity student;
        bool bOpenedImage = false;
        public FStudentInformationEdit(string strStudentId)
        {
            student = new CStudentEntity();
            this.student.StudentId = strStudentId;
            InitializeComponent();
            txtStudenId.Text = strStudentId;
        }
        
        private void FStudentInformationAdd_Load(object sender, EventArgs e)
        {
            loadComponent();
        }
        private bool loadComponent()
        {
            this.student = CStudentBusiness.loadStudentInfor(student.StudentId);
            if (student == null)
            {
                MessageBox.Show("Error load data!");
                return false;
            }
            picStudentImage.Image = loadStudentImage();
            txtStudentName.Text = student.StudentName;
            if (student.Genders)
            {
                rdoGenders.SelectedIndex = 0;
            }
            else
            {
                rdoGenders.SelectedIndex = 1;
            }
            txtDateOfBirth.Text = student.DateOfBirth.Value.ToShortDateString();
            txtAddress.Text = student.Address;

            return true;
        }

        private Image loadStudentImage()
        {
            Image image;
            if (student.StudentImage == null)
            {
                if (student.Genders)
                {
                    image = Properties.Resources.student_male_512;
                }
                else
                {
                    image = Properties.Resources.student_female_512;
                }
            }
            else
            {
                image = convertDataToImage(student.StudentImage);
            }
            return image;
        }

        private Image convertDataToImage(Byte[] imageData)
        {
            Image image;
            MemoryStream memoryStream = new MemoryStream(imageData);
            image = Image.FromStream(memoryStream);
            return image;
        }

        private void rdoGenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bOpenedImage == false)
            {
                if (rdoGenders.SelectedIndex == 0)
                {
                    picStudentImage.Image = Properties.Resources.student_male_512;
                }
                else
                {
                    picStudentImage.Image = Properties.Resources.student_female_512;
                }
            }
        }

        private void picStudentImage_Click(object sender, EventArgs e)
        {
            picStudentImage.Image = loadStudentPicturebox();
        }

        private Image loadStudentPicturebox()
        {
            Image image;
            string strPathImage = openFileImage();
            try
            {
                image = Image.FromFile(strPathImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load image\n" + ex);
                bOpenedImage = false;
                return null;
            }
            bOpenedImage = true;
            return image;
        }
        private string openFileImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string strPath = "";
            bool bReload = true;
            while (bReload)
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    strPath = openFile.FileName;
                    bReload = false;
                }
                if (strPath == "")
                {
                    DialogResult diaResual = MessageBox.Show("Not select image.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (diaResual == DialogResult.OK)
                    {
                        bReload = false;
                    }
                }
            }
            return strPath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CStudentEntity student = dataStudent();
            if (CStudentBusiness.editStudent(student) == false)
            {
                MessageBox.Show("Save failure!");
                return;
            }
            else
            {
                this.Close();
            }
        }
        private CStudentEntity dataStudent()
        {
            student.StudentName = txtStudentName.Text;
            student.Address = txtAddress.Text;
            student.Genders = rdoGenders.SelectedIndex == 0 ? true : false;
            try
            {
                string date = txtDateOfBirth.Text;
                student.DateOfBirth = DateTime.Parse(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error input Day of Birth\n" + ex.Message);
            }
            student.StudentImage = convertImageToData(picStudentImage.Image);
            return student;
        }
        private byte[] convertImageToData(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            byte[] imageBuffer = memoryStream.GetBuffer();
            memoryStream.Close();

            return imageBuffer;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDateOfBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 48 || e.KeyValue > 57)
                return;

        }
    }
}
