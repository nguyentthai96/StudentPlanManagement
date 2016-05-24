namespace StudentPlanManagementData
{
    using CustomModels;
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
            PlanEnties = Set<CPlanEntity>();
        }

        public virtual DbSet<CAccountEntity> AccountEntities { get; set; }
        public virtual DbSet<CStudentEntity> StudentEntities { get; set; }
        public virtual DbSet<CPlanEntity> PlanEnties { get; set; }

        public virtual DbSet<CSemesterEntity> SemesterEntities { get; set; }
        public virtual DbSet<CSubjectsEntity> SubjectsEntities { get; set; }
        public virtual DbSet<CInstructorEntity> InstructorEntities { get; set; }
        public virtual DbSet<CSemesterEntityCSubjectsEntity> SubjectsTakesEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAccountEntity>()
                .Property(e => e.StudentId)
                .IsUnicode(false);
            modelBuilder.Entity<CStudentEntity>()
                .HasOptional(e => e.Account)
                .WithRequired(e => e.Student);

            modelBuilder.Entity<CSemesterEntityCSubjectsEntity>()
                .HasMany(e => e.Marks)
                .WithRequired(e => e.Take);

            modelBuilder.Entity<CMarksEntity>()
                .HasRequired(e => e.Take)
                .WithMany(e => e.Marks);
        }
    }  
}