using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class WaterInjectorRateHeader
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double TotalWaterInj { get; set; }
        public double WIJUptime { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
    }
}