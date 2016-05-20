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

        public static bool editAccount(CAccountEntity acc)
        {
            try
            {
                dbContext = new StudentPlanManagementContext();
                dbContext.Entry(acc).State = EntityState.Modified;
                int i=dbContext.SaveChanges();
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
    }
}
