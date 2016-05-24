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
            #region Initializer data Semester
            context.SemesterEntities.Add(new Models.CSemesterEntity { SemesterId = "HK1", SemesterName = "Học kỳ 1", SchoolYears = "2014-2015" });
            context.SemesterEntities.Add(new Models.CSemesterEntity { SemesterId = "HK2", SemesterName = "Học kỳ 2", SchoolYears = "2014-2015" });
            context.SemesterEntities.Add(new Models.CSemesterEntity { SemesterId = "HK3", SemesterName = "Học kỳ 3", SchoolYears = "2015-2016" });
            context.SemesterEntities.Add(new Models.CSemesterEntity { SemesterId = "HK4", SemesterName = "Học kỳ 4", SchoolYears = "2015-2016" });
            context.SemesterEntities.Add(new Models.CSemesterEntity { SemesterId = "HK5", SemesterName = "Học kỳ 5", SchoolYears = "2016-2017" });
            #endregion
            #region Initializer data Subjects
            context.SubjectsEntities.Add(new Models.CSubjectsEntity { SubjectId = "LTW", SubjectName = "Lập trình trên windows", NumberLessonOfDay = 5, NumberOfCredits = 4 });
            context.SubjectsEntities.Add(new Models.CSubjectsEntity { SubjectId = "CSDL", SubjectName = "Cơ sở dữ liệu", NumberLessonOfDay = 5, NumberOfCredits = 4 });
            context.SubjectsEntities.Add(new Models.CSubjectsEntity { SubjectId = "KTMT", SubjectName = "Kiến trúc máy tính", NumberLessonOfDay = 5, NumberOfCredits = 4 });
            #endregion
            #region Initializer data Instructors
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Minh Đạo" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Lê Văn Vinh" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Trần Thi Văn" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Mai Tuấn Khôi" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Trương Thị Ngọc Phượng" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Thành Sơn" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Phương" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Đinh Công Đoan" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Hữu Trung" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Trần Công Tú" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Thiên Bảo" });
            context.InstructorEntities.Add(new Models.CInstructorEntity { InstructorName = "Nguyễn Quang Ngọc" });
            #endregion

            context.SaveChanges();
        }
    }
}
