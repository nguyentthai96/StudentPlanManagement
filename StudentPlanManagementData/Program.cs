using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<StudentPlanManagementContext>(new StudentPlanManagementInitializer());
            StudentPlanManagementContext dbContext = new StudentPlanManagementContext();
            dbContext.StudentEntities.Select(st=>st);
        }
    }
}
