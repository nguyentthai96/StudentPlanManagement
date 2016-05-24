using StudentPlanManagementData.CustomModels;
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
        public CStudentEntity()
        {
            Plants = new HashSet<CPlanEntity>();
        }

        [Key]
        [StringLength(10, MinimumLength =1)]
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public bool Genders { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public Byte[] StudentImage { get; set; }
      [ForeignKey("StudentId")]
        public virtual CAccountEntity Account { get; set; }

        public virtual ICollection<CPlanEntity> Plants { get; set; }
       
    }
}
