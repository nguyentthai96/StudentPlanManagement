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

        [NotMapped]
        public int SetWeekOfDayTypeInt
        {
            set
            {
                dWeekOfDay = (DayOfWeek)value;
            }
        }
        [NotMapped]
        public int GetWeekOfDayTypeInt
        {
            get
            {
                return dWeekOfDay.GetHashCode();
            }
        }

        private DayOfWeek dWeekOfDay;
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public string ClassRom { get; set; }
      
        public virtual CSemesterEntityCSubjectsEntity Take { get; set; }
    }
}
