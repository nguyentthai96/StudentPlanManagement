using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CSubjectsEntity
    {
        public CSubjectsEntity()
        {
            Semesters = new HashSet<CSemesterEntity>();
            Instructors = new HashSet<CInstructorEntity>();
        }
        [Key]
        [StringLength(10, MinimumLength = 1)]
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfCredits { get; set; }
        public int NumberLessonOfDay { get; set; }
        public virtual ICollection<CSemesterEntity> Semesters { get; set; }
        public ICollection<CInstructorEntity> Instructors { get; set; }
    }
}
