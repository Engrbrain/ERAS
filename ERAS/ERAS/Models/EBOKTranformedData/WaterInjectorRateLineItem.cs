using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class WaterInjectorRateLineItem
    {
        public int Id { get; set; }
        public string Well { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double ChokeSize { get; set; }
        public double UpTime { get; set; }
        public double THIP { get; set; }
        public double THSP { get; set; }
        public double FLP { get; set; }
        public double HP { get; set; }
        public double INJRate { get; set; }
        public double CumINJRate { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
        public WaterInjectorRateLineItem()
        {
            this.THSP = 0;
        }

    }
}