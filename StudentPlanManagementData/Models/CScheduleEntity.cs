using StudentPlanManagementData.CustomModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CScheduleEntity
    {
        [Key]
        public string ScheduleId { get; set; }
        public string ScheduleTitle { get; set; }

        public string WeekOfDay
        {
            get
            {
                string[] DayWeek = new string[] { "Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };
                return DayWeek[dWeekOfDay.GetHashCode()];
            }

            set
            {
                string[] DayWeek = new string[] { "Chủ nhật", "Thứ hai", "Thứ ba", "Thứ tư", "Thứ năm", "Thứ sáu", "Thứ bảy" };
                dWeekOfDay = (DayOfWeek)Array.IndexOf(DayWeek, value.ToString());
            }
        }
        
        private DayOfWeek dWeekOfDay;

        public string ClassRom { get; set; }
        public CDurationActive TimeStudy { get; set; }
        public virtual CSemesterEntityCSubjectsEntity Take { get; set; }
    }
}
