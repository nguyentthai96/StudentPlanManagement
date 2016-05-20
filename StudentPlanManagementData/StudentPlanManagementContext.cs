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
            AccountEntities = Set<CAccountEntity>();
        }

        public virtual DbSet<CStudentEntity> StudentEntities { get; set; }
        public virtual DbSet<CAccountEntity> AccountEntities { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAccountEntity>()
                .Property(e => e.StudentId)
                .IsUnicode(false);
            modelBuilder.Entity<CStudentEntity>()
                .HasOptional(e => e.Account)
                .WithRequired(e => e.Student);
        }
    }  
}