using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CStudentEntity
    {
        [Key]
        [StringLength(10,MinimumLength=1)]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public bool Genders { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public Byte[] StudentImage { get; set; }
    }
}
