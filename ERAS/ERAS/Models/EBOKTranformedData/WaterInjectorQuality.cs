﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class WaterInjectorQuality
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double SWLPumpInlet { get; set; }
        public double PH { get; set; }
        public double ParticlesUpstream { get; set; }
        public double ParticlesDownStream { get; set; }
        public string Remark { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }

    }

  
}