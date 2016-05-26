using System;
using StudentPlanManagementData.Models;
using System.Linq;

namespace StudentPlanManagementBusiness
{
    public class CMarkBusiness
    {
        private static StudentPlanManagementData.StudentPlanManagementContext dbContext;

        public static void addMarkNew(CMarksEntity mark, string strStudentId, string strSemesterId, string strSubjectId)
        {
            dbContext = new StudentPlanManagementData.StudentPlanManagementContext();
            mark.Take = dbContext.SubjectsTakesEntities.SingleOrDefault(t => t.StudentId == strStudentId && t.SemesterId == strSemesterId && t.SubjectId == strSubjectId);

            dbContext.MarkEnties.Add(mark);
            dbContext.SaveChanges();
        }
    }
}