using StudentPlanManagementData;
using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentPlanManagementBusiness
{
    public class CStudentBusiness
    {
        private static StudentPlanManagementContext dbContext;// = new StudentPlanManagementContext();
        public static CStudentEntity loadStudentInfor(string strStudentId)
        {
            dbContext = new StudentPlanManagementContext();
            CStudentEntity student = new CStudentEntity();
            student = dbContext.StudentEntities.Where(st => st.StudentId == strStudentId).SingleOrDefault();
            return student;
        }

    }
}
