﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKDailyReport
{
    public class CFBProcessData_GasProduced
    {
        public int Id { get; set; }
        public string GasSource { get; set; }
        public string Pressure { get; set; }
        public string Temperature { get; set; }
        public string GasFlowParameter { get; set; }
        public double GasFlow { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
    }
}