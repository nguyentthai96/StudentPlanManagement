using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CStudentEntity
    {
        [Key]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public bool Genders { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public Byte[] StudentImage { get; set; }
      [ForeignKey("StudentId")]
        public virtual CAccountEntity Account { get; set; }
    }
}
