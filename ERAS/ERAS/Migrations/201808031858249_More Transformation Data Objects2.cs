namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTransformationDataObjects2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackAllocationBPLDs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        Well = c.String(),
                        BPLD = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKFieldProductionSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        CumProd = c.String(),
                        ProdGas = c.String(),
                        WFBAllocatedGas = c.String(),
                        WFBFlaringUptime = c.String(),
                        Gaslift = c.String(),
                        TotalProducedGas = c.String(),
                        CumGas = c.String(),
                        ProdWater = c.String(),
                        CumWater = c.String(),
                        EffluentOilInWater = c.String(),
                        API = c.String(),
                        ExportAPI = c.String(),
                        ExportTemp = c.String(),
                        ExportMetersReadingGross = c.String(),
                        ExportMetersReadingNet = c.String(),
                        FieldWaterCut = c.String(),
                        ExportWaterCut = c.String(),
                        PumpablecargoonBoard = c.String(),
                        Adjustment = c.String(),
                        TotalMeteredGasFlared = c.String(),
                        ViriniPremStockBalance = c.String(),
                        BSW = c.String(),
                        FieldGOR = c.String(),
                        AdjustedFieldGOR = c.String(),
                        WaterOverboard = c.String(),
                        FreeWaterReceived = c.String(),
                        WaterOverboardMOPU = c.String(),
                        UllageMeasurement = c.String(),
                        MOPUcorrectedmeterVariance = c.String(),
                        BSWManual = c.String(),
                        BSWAutosampler = c.String(),
                        OffloadVolume = c.String(),
                        OffloadBSW = c.String(),
                        OffloadAPI = c.String(),
                        Forecast = c.String(),
                        IdealDayRate = c.String(),
                        MarketExpectation = c.String(),
                        Budget = c.String(),
                        Deferment = c.String(),
                        EstmatedProdGas = c.String(),
                        TargetLC = c.String(),
                        TargetHC = c.String(),
                        TechnicalAllowable = c.String(),
                        CommercialAllowable = c.String(),
                        ActualProdGas = c.String(),
                        WeeklyAverage = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKGasProductionSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        TwoPhaseSeperator = c.String(),
                        TestSeperator = c.String(),
                        ProductionSeperator = c.String(),
                        LPVessels = c.String(),
                        WFBAllocatedgas = c.String(),
                        WFBProcessUptime = c.String(),
                        WFBFlaringUptime = c.String(),
                        WFBContribution = c.String(),
                        WFBPROCESSTOTAL = c.String(),
                        WFBGasLift = c.String(),
                        TOTALGasLift = c.String(),
                        GeneratorFuel = c.String(),
                        FuelGasKOD = c.String(),
                        GTCompressorconsumption = c.String(),
                        CalcuatedInjectedGas = c.String(),
                        MeteredGasInjected = c.String(),
                        GASUtilizationTotal = c.String(),
                        HPFLARE = c.String(),
                        LPFLARE = c.String(),
                        WFBGasFlared = c.String(),
                        TotalMeteredGasFlared = c.String(),
                        GASFLAREDTOTAL = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.GasInjectorDailyIndicators", "Well", c => c.String(maxLength: 50));
            DropColumn("dbo.GasInjectorDailyIndicators", "FlowDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GasInjectorDailyIndicators", "FlowDescription", c => c.String());
            DropColumn("dbo.GasInjectorDailyIndicators", "Well");
            DropTable("dbo.EBOKGasProductionSummaries");
            DropTable("dbo.EBOKFieldProductionSummaries");
            DropTable("dbo.BackAllocationBPLDs");
        }
    }
}
