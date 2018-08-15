using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class EKOBDailyProductionIndicator
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Well { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double ChokeSize { get; set; }
        public double Uptime { get; set; }
        public double THP { get; set; }
        public double FLP { get; set; }
        public double BSW { get; set; }
        public double BHT { get; set; }
        public double AnnulusPressure { get; set; }
        public double Frequency { get; set; }
        public double SAND { get; set; }
        public double GROSSAPI { get; set; }
        public double NETAPI { get; set; }
        public double PS { get; set; }
        public double PWF { get; set; }
        public double DP { get; set; }
        public double OilBOPD { get; set; }
        public double WaterBWPD { get; set; }
        public double GASMMSCFD { get; set; }
        public double PI { get; set; }
        public double MaxWaterCut { get; set; }
        public double GOR { get; set; }
        [MaxLength(1500)]
        public string REMARK { get; set; }
        public double BLPD { get; set; }
        public double GASMSCFD { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
    }
}