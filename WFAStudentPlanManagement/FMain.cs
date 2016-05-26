using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StudentPlanManagementBusiness;
using StudentPlanManagementData.Models;

namespace WFAStudentPlanManagement
{
    public partial class FMain : DevExpress.XtraEditors.XtraForm
    {
        private CStudentEntity student;
        private CSemesterEntity semester;
        public FMain()
        {
            this.student = null;
            this.semester = new CSemesterEntity();
            this.semester.SemesterId = "HK4";
            this.semester.SemesterName = "Học kỳ 4";
            this.semester.SchoolYears = "2015-2016";
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }
    }
}