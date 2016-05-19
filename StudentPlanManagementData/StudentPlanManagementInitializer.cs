using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentPlanManagementData
{
    public class StudentPlanManagementInitializer:DropCreateDatabaseIfModelChanges<StudentPlanManagementContext>
    {
        protected override void Seed(StudentPlanManagementContext context)
        {
            
        }
    }
}
