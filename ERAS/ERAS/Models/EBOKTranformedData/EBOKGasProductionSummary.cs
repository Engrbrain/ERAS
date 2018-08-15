using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class EBOKGasProductionSummary
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double TwoPhaseSeperator { get; set; }
        public double TestSeperator { get; set; }
        public double ProductionSeperator { get; set; }
        public double LPVessels { get; set; }
        public double WFBAllocatedgas { get; set; }
        public double WFBProcessUptime { get; set; }
        public double WFBFlaringUptime { get; set; }
        public double WFBContribution { get; set; }
        public double WFBPROCESSTOTAL { get; set; }
        public double WFBGasLift { get; set; }
        public double CFBGasLift { get; set; }
        public double TOTALGasLift { get; set; }
        public double GeneratorFuel { get; set; }
        public double FuelGasKOD { get; set; }
        public double GTCompressorconsumption { get; set; }
        public double CalcuatedInjectedGas { get; set; }
        public double MeteredGasInjected { get; set; }
        public double GASUtilizationTotal { get; set; }
        public double HPFLARE { get; set; }
        public double LPFLARE { get; set; }
        public double WFBGasFlared { get; set; }
        public double TotalMeteredGasFlared { get; set; }
        public double GASFLAREDTOTAL { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }


    }

}