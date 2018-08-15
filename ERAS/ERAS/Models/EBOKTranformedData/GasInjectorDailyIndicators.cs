using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class GasInjectorDailyIndicators
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double ChokeSize { get; set; }
        public double Uptime { get; set; }
        public string Well { get; set; }
        public double CompDischPress { get; set; }
        public double GasInject { get; set; }
        public double IFLP { get; set; }
        public double IFLSkinTemp { get; set; }
        public double ITHP { get; set; }
        public double IBHP { get; set; }
        public string IBHT { get; set; }
        public string Remark { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }

    }
}