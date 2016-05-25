using StudentPlanManagementData.Models;
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
    public partial class FMarkAdd : Form
    {
        private string strStudentId;
        private string strSemesterId;
        private string strSubjectId;
        private List<CSubjectsEntity> listSubjects;
        public FMarkAdd(string strStudentId, string strSemesterId)
        {
            this.strStudentId = strStudentId;
            this.strSemesterId = strSemesterId;
            InitializeComponent();
        }

        private void FMarkAdd_Load(object sender, EventArgs e)
        {
            loadCmbSubject();
        }

        private void loadCmbSubject()
        {
           listSubjects=  StudentPlanManagementBusiness.CSubjectBusness.loadListSubjectRegisted(strStudentId, strSemesterId);
            foreach (CSubjectsEntity s in listSubjects)
            {
                cmbSubject.Properties.Items.Add(s.SubjectName);
            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            strSubjectId = listSubjects[cmbSubject.SelectedIndex].SubjectId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CMarksEntity mark;
            mark = getDataForm();
            StudentPlanManagementBusiness.CMarkBusiness.addMarkNew(mark,strStudentId, strSemesterId, strSubjectId);
            this.Close();
        }

        private CMarksEntity getDataForm()
        {
            CMarksEntity mark;
            mark = new CMarksEntity
            {
                Score = float.Parse(txtMarkScore.Text),
                Ratio = int.Parse(txtMarkScore.Text),
                DayOfMark = dtDayOfMark.DateTime,
                DescribeMark = txtMarkDescrible.Text,
            };

            return mark;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
