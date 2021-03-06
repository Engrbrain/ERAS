namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedatatypeoffields : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EBOKInjectivityIndexViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        UpTime = c.Double(nullable: false),
                        IndicatorDate = c.DateTime(nullable: false),
                        INJRate = c.Double(nullable: false),
                        THIP = c.Double(nullable: false),
                        THSP = c.Double(nullable: false),
                        ScaledupRate = c.Double(nullable: false),
                        InjectivityIndex = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.WaterInjectorRateLineItems", "THSP", c => c.Double(nullable: false));
            AddColumn("dbo.WellTestEnrichmentDatas", "FaultBlock", c => c.String(maxLength: 15));
            AlterColumn("dbo.BackAllocationBPLDs", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BackAllocationBPLDs", "BPLD", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Uptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdOil", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumProd", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WFBAllocatedGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WFBFlaringUptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Gaslift", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TotalProducedGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "EffluentOilInWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "API", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportTemp", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportMetersReadingGross", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportMetersReadingNet", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FieldWaterCut", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportWaterCut", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "PumpablecargoonBoard", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Adjustment", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TotalMeteredGasFlared", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ViriniPremStockBalance", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSW", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FieldGOR", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "AdjustedFieldGOR", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WaterOverboard", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FreeWaterReceived", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WaterOverboardMOPU", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "UllageMeasurement", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "MOPUcorrectedmeterVariance", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSWManual", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSWAutosampler", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadVolume", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadBSW", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Forecast", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "IdealDayRate", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "MarketExpectation", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Budget", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Deferment", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "EstmatedProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TargetLC", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TargetHC", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TechnicalAllowable", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CommercialAllowable", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ActualProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WeeklyAverage", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "TwoPhaseSeperator", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "TestSeperator", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "ProductionSeperator", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "LPVessels", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBAllocatedgas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBProcessUptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBFlaringUptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBContribution", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBPROCESSTOTAL", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBGasLift", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "CFBGasLift", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "TOTALGasLift", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "GeneratorFuel", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "FuelGasKOD", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "GTCompressorconsumption", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "CalcuatedInjectedGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "MeteredGasInjected", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "GASUtilizationTotal", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "HPFLARE", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "LPFLARE", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBGasFlared", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "TotalMeteredGasFlared", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKGasProductionSummaries", "GASFLAREDTOTAL", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String(maxLength: 150));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Uptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "THP", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "FLP", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BSW", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHT", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "AnnulusPressure", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Frequency", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "SAND", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GROSSAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "NETAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PS", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PWF", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "DP", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "OilBOPD", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "WaterBWPD", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMMSCFD", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PI", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GOR", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "REMARK", c => c.String(maxLength: 1500));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BLPD", c => c.Double(nullable: false));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMSCFD", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "ChokeSize", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "Uptime", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "Well", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "CompDischPress", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "GasInject", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "IFLP", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "IFLSkinTemp", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "ITHP", c => c.Double(nullable: false));
            AlterColumn("dbo.GasInjectorDailyIndicators", "IBHP", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorQualities", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WaterInjectorQualities", "SWLPumpInlet", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorQualities", "PH", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorQualities", "ParticlesUpstream", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorQualities", "ParticlesDownStream", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateHeaders", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WaterInjectorRateHeaders", "TotalWaterInj", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateHeaders", "WIJUptime", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "IndicatorDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "ChokeSize", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "UpTime", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "THIP", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "FLP", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "HP", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "INJRate", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterInjectorRateLineItems", "CumINJRate", c => c.Double(nullable: false));
            DropColumn("dbo.EKOBDailyProductionIndicators", "BHP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EKOBDailyProductionIndicators", "BHP", c => c.String(maxLength: 50));
            AlterColumn("dbo.WaterInjectorRateLineItems", "CumINJRate", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "INJRate", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "HP", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "FLP", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "THIP", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "UpTime", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "ChokeSize", c => c.String());
            AlterColumn("dbo.WaterInjectorRateLineItems", "IndicatorDate", c => c.String());
            AlterColumn("dbo.WaterInjectorRateHeaders", "WIJUptime", c => c.String());
            AlterColumn("dbo.WaterInjectorRateHeaders", "TotalWaterInj", c => c.String());
            AlterColumn("dbo.WaterInjectorRateHeaders", "IndicatorDate", c => c.String());
            AlterColumn("dbo.WaterInjectorQualities", "ParticlesDownStream", c => c.String());
            AlterColumn("dbo.WaterInjectorQualities", "ParticlesUpstream", c => c.String());
            AlterColumn("dbo.WaterInjectorQualities", "PH", c => c.String());
            AlterColumn("dbo.WaterInjectorQualities", "SWLPumpInlet", c => c.String());
            AlterColumn("dbo.WaterInjectorQualities", "IndicatorDate", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "IBHP", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "ITHP", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "IFLSkinTemp", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "IFLP", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "GasInject", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "CompDischPress", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "Well", c => c.String(maxLength: 50));
            AlterColumn("dbo.GasInjectorDailyIndicators", "Uptime", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "ChokeSize", c => c.String());
            AlterColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMSCFD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BLPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "REMARK", c => c.String(maxLength: 500));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GOR", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMMSCFD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "WaterBWPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "OilBOPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "DP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PWF", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PS", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "NETAPI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GROSSAPI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "SAND", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Frequency", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "AnnulusPressure", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHT", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BSW", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "FLP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "THP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Uptime", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String(maxLength: 50));
            AlterColumn("dbo.EBOKGasProductionSummaries", "GASFLAREDTOTAL", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "TotalMeteredGasFlared", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBGasFlared", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "LPFLARE", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "HPFLARE", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "GASUtilizationTotal", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "MeteredGasInjected", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "CalcuatedInjectedGas", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "GTCompressorconsumption", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "FuelGasKOD", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "GeneratorFuel", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "TOTALGasLift", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "CFBGasLift", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBGasLift", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBPROCESSTOTAL", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBContribution", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBFlaringUptime", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBProcessUptime", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "WFBAllocatedgas", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "LPVessels", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "ProductionSeperator", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "TestSeperator", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "TwoPhaseSeperator", c => c.String());
            AlterColumn("dbo.EBOKGasProductionSummaries", "IndicatorDate", c => c.String(maxLength: 50));
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WeeklyAverage", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ActualProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CommercialAllowable", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TechnicalAllowable", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TargetHC", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TargetLC", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "EstmatedProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Deferment", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Budget", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "MarketExpectation", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "IdealDayRate", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Forecast", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadAPI", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadBSW", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "OffloadVolume", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSWAutosampler", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSWManual", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "MOPUcorrectedmeterVariance", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "UllageMeasurement", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WaterOverboardMOPU", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FreeWaterReceived", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WaterOverboard", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "AdjustedFieldGOR", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FieldGOR", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "BSW", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ViriniPremStockBalance", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TotalMeteredGasFlared", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Adjustment", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "PumpablecargoonBoard", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportWaterCut", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "FieldWaterCut", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportMetersReadingNet", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportMetersReadingGross", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportTemp", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ExportAPI", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "API", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "EffluentOilInWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "TotalProducedGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Gaslift", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WFBFlaringUptime", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "WFBAllocatedGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "CumProd", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "ProdOil", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "Uptime", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaries", "IndicatorDate", c => c.String());
            AlterColumn("dbo.BackAllocationBPLDs", "BPLD", c => c.String());
            AlterColumn("dbo.BackAllocationBPLDs", "IndicatorDate", c => c.String());
            DropColumn("dbo.WellTestEnrichmentDatas", "FaultBlock");
            DropColumn("dbo.WaterInjectorRateLineItems", "THSP");
            DropTable("dbo.EBOKInjectivityIndexViewModels");
        }
    }
}
