using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Business
{
    public class CStudentBusiness
    {
       // private StudentPlanManagementContext dbContext;// = new StudentPlanManagementContext();
        public CStudentEntity loadStudentInfor(string strStudentId)
        {
            using (var dbContext = new StudentPlanManagementContext())
            {
                CStudentEntity student;
                student = dbContext.StudentEntities.Where(st => st.StudentId == strStudentId).SingleOrDefault();
                return student;
            }
        }
    }
}
