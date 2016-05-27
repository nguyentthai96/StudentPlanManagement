using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAStudentPlanManagement.FormMarks
{
    public partial class FSummaryMarks : Form
    {
        private string strStudentId;
        private string strSemesterId;
        public FSummaryMarks(string strStudentId, string strSemesterId)
        {
            this.strStudentId = strStudentId;
            this.strSemesterId = strSemesterId;
            InitializeComponent();
        }

        private void FSummaryMarks_Load(object sender, EventArgs e)
        {

        }

        private void pnlCalculateLeft_Resize(object sender, EventArgs e)
        {
            int x = pnlCalculateRight.Width / 2 - lblAveragePoints.Width / 2;
            lblAveragePoints.Location = new Point(x, lblAveragePoints.Location.Y);
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbChkFillSemester_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
