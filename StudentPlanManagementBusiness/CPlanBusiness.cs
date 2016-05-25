using System;
using StudentPlanManagementData.Models;
using System.Linq;
namespace StudentPlanManagementBusiness
{
    public class CPlanBusiness
    {
        private static StudentPlanManagementData.StudentPlanManagementContext dbContext;
        public static string getPlanIdNew()
        {
            dbContext = new StudentPlanManagementData.StudentPlanManagementContext();
            if (dbContext.PlanEnties.Count() == 0)
            {
                return "P0";
            }

            int maxLengthPlanId = dbContext.PlanEnties.Max(p => p.PlandId.Length);
            var lastPlan = dbContext.PlanEnties.Where(p=>p.PlandId.Length==maxLengthPlanId).Max(p => p.PlandId.Substring(1));
          
           string strPlanIdNeew="P"+ (int.Parse(lastPlan)+1);
            return strPlanIdNeew;
        }

        public static void addPlan(CPlanEntity planData)
        {
            dbContext = new StudentPlanManagementData.StudentPlanManagementContext();
            planData.Student = dbContext.StudentEntities.SingleOrDefault(s => s.StudentId == planData.Student.StudentId); //TODO tai sao loi da them o truoc ma
            dbContext.PlanEnties.Add(planData);
            dbContext.SaveChanges();
        }
    }
}