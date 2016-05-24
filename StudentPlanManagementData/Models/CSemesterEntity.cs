using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CSemesterEntity
    {
        public CSemesterEntity()
        {
            Subjects = new HashSet<CSubjectsEntity>();
        }
        [Key]
        [StringLength(10, MinimumLength = 1)]
        public string SemesterId { get; set; }
        public string SemesterName { get; set; }
        public string SchoolYears { get; set; }
        public virtual ICollection<CSubjectsEntity> Subjects { get; set; }
    }
}
