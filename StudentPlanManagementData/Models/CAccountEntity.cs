using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CAccountEntity
    {
        [Key]
        public string StudentId { get; set; }
        public string Password { get; set; }
        public bool IsAcctive { get; set; }
        public DateTime DateOfRegister { get; set; }
        [ForeignKey("StudentId")]
        public virtual CStudentEntity Student { get; set; }
    }
}
