using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class BackAllocationAssumedGOR
    {
        public int Id { get; set; }
        public string Well { get; set; }
        public string IndicatorDate { get; set; }
        public double AssumedGOR { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
    }
}