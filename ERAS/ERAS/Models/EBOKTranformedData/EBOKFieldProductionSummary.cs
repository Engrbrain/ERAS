using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKTranformedData
{
    public class EBOKFieldProductionSummary
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double Uptime { get; set; }
        public double ProdOil { get; set; }
        public double CumProd { get; set; }
        public double ProdGas { get; set; }
        public double WFBAllocatedGas { get; set; }
        public double WFBFlaringUptime { get; set; }
        public double Gaslift { get; set; }
        public double TotalProducedGas { get; set; }
        public double CumGas { get; set; }
        public double ProdWater { get; set; }
        public double CumWater { get; set; }
        public double EffluentOilInWater { get; set; }
        public double API { get; set; }
        public double ExportAPI { get; set; }
        public double ExportTemp { get; set; }
        public double ExportMetersReadingGross { get; set; }
        public double ExportMetersReadingNet { get; set; }
        public double FieldWaterCut { get; set; }
        public double ExportWaterCut { get; set; }
        public double PumpablecargoonBoard { get; set; }
        public double Adjustment { get; set; }
        public double TotalMeteredGasFlared { get; set; }
        public double ViriniPremStockBalance { get; set; }
        public double BSW { get; set; }
        public double FieldGOR { get; set; }
        public double AdjustedFieldGOR { get; set; }
        public double WaterOverboard { get; set; }
        public double FreeWaterReceived { get; set; }
        public double WaterOverboardMOPU { get; set; }
        public double UllageMeasurement { get; set; }
        public double MOPUcorrectedmeterVariance { get; set; }
        public double BSWManual { get; set; }
        public double BSWAutosampler { get; set; }
        public double OffloadVolume { get; set; }
        public double OffloadBSW { get; set; }
        public double OffloadAPI { get; set; }
        public double Forecast { get; set; }
        public double IdealDayRate { get; set; }
        public double MarketExpectation { get; set; }
        public double Budget { get; set; }
        public double Deferment { get; set; }
        public double EstmatedProdGas { get; set; }
        public double TargetLC { get; set; }
        public double TargetHC { get; set; }
        public double TechnicalAllowable { get; set; }
        public double CommercialAllowable { get; set; }
        public double ActualProdGas { get; set; }
        public double WeeklyAverage { get; set; }
        public DateTime ReportDate { get; set; }
        public String UploadTime { get; set; }
        public DateTime TimeStamp { get; set; }
        public string DayOftheWeek { get; set; }
    }

}