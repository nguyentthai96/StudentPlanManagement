using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CInstructorEntity
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public virtual CSubjectsEntity Subject { get; set; }
    }
}
