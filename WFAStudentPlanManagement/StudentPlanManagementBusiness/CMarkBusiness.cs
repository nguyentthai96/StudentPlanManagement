using System;
using StudentPlanManagementData.Models;
using DevExpress.Data.Linq.Helpers;
using System.Linq;

namespace StudentPlanManagementBusiness
{
    internal class CMarkBusiness
    {
        private static StudentPlanManagementData.StudentPlanManagementContext dbContext;

        internal static void addMarkNew(CMarksEntity mark, string strStudentId, string strSemesterId, string strSubjectId)
        {
            dbContext = new StudentPlanManagementData.StudentPlanManagementContext();
            mark.Take = dbContext.SubjectsTakesEntities.SingleOrDefault(t => t.StudentId == strStudentId && t.SemesterId == strSemesterId && t.SubjectId == strSubjectId);

            dbContext.MarkEnties.Add(mark);
            dbContext.SaveChanges();
        }
    }
}