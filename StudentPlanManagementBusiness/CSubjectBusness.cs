using System;
using System.Collections.Generic;
using StudentPlanManagementData.Models;
using StudentPlanManagementData;
using System.Data.Entity;
using System.Linq;

namespace StudentPlanManagementBusiness
{
    public class CSubjectBusness
    {
        private static StudentPlanManagementContext dbContext;
        public static List<CSubjectsEntity> loadListSubjectFullTable()
        {
            dbContext = new StudentPlanManagementContext();
            List<CSubjectsEntity> lists = new List<CSubjectsEntity>();
            lists = dbContext.SubjectsEntities.Select(s => s).ToList();
            return lists;
        }
    }
}