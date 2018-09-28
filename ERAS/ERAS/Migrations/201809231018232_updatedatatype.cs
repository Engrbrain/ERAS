namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BackAllocationAssumedGORStagings", "Well", c => c.String(maxLength: 150));
            AlterColumn("dbo.BackAllocationBPLDs", "Well", c => c.String(maxLength: 150));
            AlterColumn("dbo.BackAllocationBPLDStagings", "Well", c => c.String(maxLength: 150));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Uptime", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdOil", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumProd", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WFBAllocatedGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WFBFlaringUptime", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Gaslift", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TotalProducedGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "EffluentOilInWater", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "API", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportAPI", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportTemp", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportMetersReadingGross", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportMetersReadingNet", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FieldWaterCut", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportWaterCut", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "PumpablecargoonBoard", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Adjustment", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TotalMeteredGasFlared", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ViriniPremStockBalance", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSW", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FieldGOR", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "AdjustedFieldGOR", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WaterOverboard", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FreeWaterReceived", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WaterOverboardMOPU", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "UllageMeasurement", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "MOPUcorrectedmeterVariance", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSWManual", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSWAutosampler", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadVolume", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadBSW", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadAPI", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Forecast", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "IdealDayRate", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "MarketExpectation", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Budget", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Deferment", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "EstmatedProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TargetLC", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TargetHC", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TechnicalAllowable", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CommercialAllowable", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ActualProdGas", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WeeklyAverage", c => c.String());
            AlterColumn("dbo.BackAllocationAssumedGORs", "Well", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BackAllocationAssumedGORs", "Well", c => c.String());
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WeeklyAverage", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ActualProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CommercialAllowable", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TechnicalAllowable", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TargetHC", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TargetLC", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "EstmatedProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Deferment", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Budget", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "MarketExpectation", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "IdealDayRate", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Forecast", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadBSW", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "OffloadVolume", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSWAutosampler", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSWManual", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "MOPUcorrectedmeterVariance", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "UllageMeasurement", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WaterOverboardMOPU", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FreeWaterReceived", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WaterOverboard", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "AdjustedFieldGOR", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FieldGOR", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "BSW", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ViriniPremStockBalance", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TotalMeteredGasFlared", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Adjustment", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "PumpablecargoonBoard", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportWaterCut", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "FieldWaterCut", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportMetersReadingNet", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportMetersReadingGross", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportTemp", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ExportAPI", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "API", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "EffluentOilInWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdWater", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "TotalProducedGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Gaslift", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WFBFlaringUptime", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "WFBAllocatedGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdGas", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "CumProd", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "ProdOil", c => c.Double(nullable: false));
            AlterColumn("dbo.EBOKFieldProductionSummaryStagings", "Uptime", c => c.Double(nullable: false));
            AlterColumn("dbo.BackAllocationBPLDStagings", "Well", c => c.String());
            AlterColumn("dbo.BackAllocationBPLDs", "Well", c => c.String());
            AlterColumn("dbo.BackAllocationAssumedGORStagings", "Well", c => c.String());
        }
    }
}
