using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class EKOBDailyProductionIndicator
    {
        public int Id { get; set; }
        public string Well { get; set; }
        public string IndicatorDate { get; set; }
        public string THP { get; set; }
        public string FLP { get; set; }
        public string BSW { get; set; }
        public string BHT { get; set; }
        public string AnnulusPressure { get; set; }
        public string SAND { get; set; }
        public string GROSSAPI { get; set; }
        public string NETAPI { get; set; }
        public string PS { get; set; }
        public string PWF { get; set; }
        public string DP { get; set; }
        public string OilBOPD { get; set; }
        public string WaterBWPD { get; set; }
        public string GASMMSCFD { get; set; }
        public string PI { get; set; }
        public string GOR { get; set; }
        public string REMARK { get; set; }
        public string BLPD { get; set; }
        public string GASMSCFD { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }


    }
}