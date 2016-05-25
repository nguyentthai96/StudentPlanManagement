using System;
using StudentPlanManagementData.CustomModels;
using StudentPlanManagementData;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Data.Linq;
using System.Linq;

namespace StudentPlanManagementBusiness
{
    public class CTakeSubjectBusiness //Khong su dung nua muon la tat ca la da duoc dang ky truoc mat dinh, neu khi mo rong chuc nang co the co dung toi
    {
        private static StudentPlanManagementContext dbContext;
        public static void addSubjectSemester(CSemesterEntityCSubjectsEntity takeDataSemesterSubject, int iInstructorId)
        {
            dbContext = new StudentPlanManagementContext();
            takeDataSemesterSubject.Instructor= dbContext.InstructorEntities.SingleOrDefault(intr => intr.InstructorId == iInstructorId);
            dbContext.SubjectsTakesEntities.Add(takeDataSemesterSubject);
            dbContext.SaveChanges(); //An error occurred while saving entities that do not expose foreign key properties for their relationships. The EntityEntries property will return null because a single entity cannot be identified as the source of the exception. Handling of exceptions while saving can be made easier by exposing foreign key properties in your entity types. See the InnerException for details. do dax co tren databese luu trungf lai

        }
    }
}