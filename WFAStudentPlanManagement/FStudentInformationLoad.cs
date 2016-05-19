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

namespace WFAStudentPlanManagement
{
    public partial class FStudentInformationLoad : Form
    {
        private string strStudentId;
        CStudentEntity student;
        public FStudentInformationLoad(string strStudentId)
        {
            this.strStudentId = strStudentId;
            InitializeComponent();
        }

        private void FStudentInformation_Load(object sender, EventArgs e)
        {
            loadComponent();
        }

        private bool loadComponent()
        {
              this.student= CStudentBusiness.loadStudentInfor(this.strStudentId);
            if (student==null)
            {
                MessageBox.Show("Error load data!");
                return false;
            }
            picStudentImage.Image = loadStudentImage();
            txtStudentName.Text = student.StudentName;
            txtGenders.Text = student.Genders?"Nam": "Nữ";
            txtDateOfBirth.Text = student.DateOfBirth.Value.ToShortDateString();
            txtAddress.Text = student.Address;

            return true;
        }

        private Image loadStudentImage()
        {
            Image image;
            if (student.StudentImage==null)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
