using System;
using System.Collections.Generic;
using StudentPlanManagementData.Models;
using StudentPlanManagementData;
using System.Linq;

namespace StudentPlanManagementBusiness
{
    public class CInstructorBusness
    {
        private static StudentPlanManagementContext dbContext;
        public static List<CInstructorEntity> loadInstructorFullTable()
        {
            dbContext = new StudentPlanManagementContext();
            List<CInstructorEntity> lists = new List<CInstructorEntity>();
            lists = dbContext.InstructorEntities.Select(s => s).ToList();
            return lists;
        }

        public static List<CInstructorEntity> loadInstructorForSubject(string strSubjectId)
        {
            dbContext = new StudentPlanManagementContext();
            List<CInstructorEntity> lists = new List<CInstructorEntity>();

            var intructorSubjects = dbContext.SubjectsEntities.Where(s => s.SubjectId.Trim() == strSubjectId);
            foreach (var item in intructorSubjects)
            {
                foreach(var intru in item.Instructors)
                    lists.Add(intru);
            }
            
            return lists;
        }
    }
}