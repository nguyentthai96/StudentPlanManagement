using StudentPlanManagementData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.CustomModels
{
    public class CSemesterEntityCSubjectsEntity
    {
        public CSemesterEntityCSubjectsEntity()
        {
            Marks = new HashSet<CMarksEntity>();
            Schedules = new HashSet<CScheduleEntity>();
        }

        [Key, Column(Order = 0)]
        public string SemesterId { get; set; }
        [Key, Column(Order = 1)]
        public string SubjectId { get; set; }
        [Key, Column(Order = 2)]
        public string StudentId { get; set; }

        public DateTime DateOfTake { get; set; }

        public virtual CSemesterEntity Semester { get; set; }
        public virtual CSubjectsEntity Subjects { get; set; }
       public virtual CStudentEntity Students { get; set; }
        
        public virtual ICollection<CMarksEntity> Marks { get; set; }
        public virtual ICollection<CScheduleEntity> Schedules { get; set; }
        public CInstructorEntity Instructor { get; set; }
    }
}
