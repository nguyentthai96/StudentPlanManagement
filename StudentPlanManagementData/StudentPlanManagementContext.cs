namespace StudentPlanManagementData
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentPlanManagementContext : DbContext
    {
        public StudentPlanManagementContext()
            : base("name=SudentPlanManagementContext")
        {
            StudentEntities = Set<CStudentEntity>();
        }

        public virtual DbSet<CStudentEntity> StudentEntities { get; set; }
    }

   
}