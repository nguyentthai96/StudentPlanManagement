using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
public    class CPlanEntity
    {
        [Key]
        [StringLength(10,MinimumLength =1)]
        public string PlandId { get; set; }
        public string PlanTitle { get; set; }
        public string Contents { get; set; }
        public string Describe { get; set; }
        public CDurationActive Duration { get; set; }
        public DateTime DayofRemind { get; set; }
        public CStudentEntity Student { get; set; }
    }
}
