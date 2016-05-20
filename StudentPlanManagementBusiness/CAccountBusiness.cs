using StudentPlanManagementData;
using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementBusiness
{
   public class CAccountBusiness
    {
        private static StudentPlanManagementContext dbContext ;

        public static bool addAccount(CAccountEntity acc)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                dbContext.AccountEntities.Add(acc);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            
            return true;
        }
        //TODO Tại sao hai cái CAccountEntity và CStudentEntity là ngang nhau đều là one to one relationship, sao lại khi tạo ra cái CAccountEntity trước lại không lỗi mà khi tạo
        //CStudentEntity trước lại lỗi An error occurred while updating the entries. See the inner exception for details.
        //hay sửa dữ liệu cũng vậy
        public static bool editAccount(CAccountEntity acc)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                //TODO lam sao để dùng được lệnh này cho one to one relationship dbContext.Entry(acc).State = EntityState.Modified;
                var studentNew = dbContext.AccountEntities.Find(acc.StudentId);
                studentNew.Password = acc.StudentId;
                int i = dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

            return true;
        }

        public static bool deleteAccount(string strAccountId)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                dbContext.AccountEntities.Find(strAccountId).IsAcctive = false; ;
                int i = dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

            return true;
        }

        public static bool checkPassword(string studentId, string strPassword)
        {
            dbContext = new StudentPlanManagementContext();
            CAccountEntity acc = new CAccountEntity();
            try
            {
                acc = dbContext.AccountEntities.Single(a => a.StudentId == studentId && a.Password == strPassword &&a.IsAcctive==true);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
           if (acc==null)
            {
                return false;
            }
            return true;
        }

        public static CAccountEntity loadAccount(string studentId)
        {
            dbContext = new StudentPlanManagementContext();
            return dbContext.AccountEntities.SingleOrDefault(st=>st.StudentId==studentId);
        }
    }
}
