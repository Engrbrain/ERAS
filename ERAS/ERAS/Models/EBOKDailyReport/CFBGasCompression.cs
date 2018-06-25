using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKDailyReport
{
    public class CFBGasCompression
    {
        public int Id { get; set; }
        public string Compressor { get; set; }
        public string SuctionPressure { get; set; }
        public string DischargePressure { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }

    }
}