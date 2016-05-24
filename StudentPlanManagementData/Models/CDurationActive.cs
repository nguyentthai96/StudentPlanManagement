﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPlanManagementData.Models
{
    public class CDurationActive
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
    }
}
