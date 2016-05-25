using StudentPlanManagementData;
using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;

namespace StudentPlanManagementBusiness
{
    public class CStudentBusiness
    {
        private static StudentPlanManagementContext dbContext;
        public static CStudentEntity loadStudentInfor(string strStudentId)
        {
            dbContext = new StudentPlanManagementContext();
            CStudentEntity student = new CStudentEntity();
            student = dbContext.StudentEntities.Where(st => st.StudentId == strStudentId).SingleOrDefault();
            return student;
        }

        public static bool addStudent(CStudentEntity student)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                dbContext.StudentEntities.Add(student);
                if (dbContext.SaveChanges() == 0)
                {
                    return false;
                }
            }
            catch (DbEntityValidationException)
            {
                return false;
            }
            catch(DbUpdateException ex)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool editStudent(CStudentEntity student)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                //Todo dùng nhưng thất bại student.Account = CAccountBusiness.loadAccount(student.StudentId);
                //ToDo làm sao dung dươc nếu là quan hệ one to one dbContext.Entry(student).State = EntityState.Modified;
                var studentNew=dbContext.StudentEntities.Find(student.StudentId);
                studentNew.StudentName = student.StudentName;
                studentNew.Genders = student.Genders;
                studentNew.DateOfBirth = student.DateOfBirth;
                studentNew.Address = student.Address;
                studentNew.StudentImage = student.StudentImage;
                int countSave = dbContext.SaveChanges();
                if ( countSave== 0)
                {
                    return false;
                }
            }
            catch (DbEntityValidationException)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static CStudentEntity getStudentData(string strStudentId)
        {
            dbContext = new StudentPlanManagementContext();
            return dbContext.StudentEntities.SingleOrDefault(s => s.StudentId == strStudentId);
        }
    }
}
