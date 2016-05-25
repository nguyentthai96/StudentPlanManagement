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
    public class CMarksEntity
    {
        [Key]
        public int MarkId { get; set; }
        public float Score { get; set; }
        public float Ratio { get; set; }
        public DateTime DayOfMark { get; set; }
        public string DescribeMark { get; set; }
        public virtual CSemesterEntityCSubjectsEntity Take { get; set; }
    }
}