namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStagingArea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackAllocationAssumedGORStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        IndicatorDate = c.String(),
                        AssumedGOR = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationBPLDStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Well = c.String(),
                        BPLD = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKFieldProductionSummaryStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Uptime = c.Double(nullable: false),
                        ProdOil = c.Double(nullable: false),
                        CumProd = c.Double(nullable: false),
                        ProdGas = c.Double(nullable: false),
                        WFBAllocatedGas = c.Double(nullable: false),
                        WFBFlaringUptime = c.Double(nullable: false),
                        Gaslift = c.Double(nullable: false),
                        TotalProducedGas = c.Double(nullable: false),
                        CumGas = c.Double(nullable: false),
                        ProdWater = c.Double(nullable: false),
                        CumWater = c.Double(nullable: false),
                        EffluentOilInWater = c.Double(nullable: false),
                        API = c.Double(nullable: false),
                        ExportAPI = c.Double(nullable: false),
                        ExportTemp = c.Double(nullable: false),
                        ExportMetersReadingGross = c.Double(nullable: false),
                        ExportMetersReadingNet = c.Double(nullable: false),
                        FieldWaterCut = c.Double(nullable: false),
                        ExportWaterCut = c.Double(nullable: false),
                        PumpablecargoonBoard = c.Double(nullable: false),
                        Adjustment = c.Double(nullable: false),
                        TotalMeteredGasFlared = c.Double(nullable: false),
                        ViriniPremStockBalance = c.Double(nullable: false),
                        BSW = c.Double(nullable: false),
                        FieldGOR = c.Double(nullable: false),
                        AdjustedFieldGOR = c.Double(nullable: false),
                        WaterOverboard = c.Double(nullable: false),
                        FreeWaterReceived = c.Double(nullable: false),
                        WaterOverboardMOPU = c.Double(nullable: false),
                        UllageMeasurement = c.Double(nullable: false),
                        MOPUcorrectedmeterVariance = c.Double(nullable: false),
                        BSWManual = c.Double(nullable: false),
                        BSWAutosampler = c.Double(nullable: false),
                        OffloadVolume = c.Double(nullable: false),
                        OffloadBSW = c.Double(nullable: false),
                        OffloadAPI = c.Double(nullable: false),
                        Forecast = c.Double(nullable: false),
                        IdealDayRate = c.Double(nullable: false),
                        MarketExpectation = c.Double(nullable: false),
                        Budget = c.Double(nullable: false),
                        Deferment = c.Double(nullable: false),
                        EstmatedProdGas = c.Double(nullable: false),
                        TargetLC = c.Double(nullable: false),
                        TargetHC = c.Double(nullable: false),
                        TechnicalAllowable = c.Double(nullable: false),
                        CommercialAllowable = c.Double(nullable: false),
                        ActualProdGas = c.Double(nullable: false),
                        WeeklyAverage = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKGasProductionSummaryStagings",
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
                        CFBGasLift = c.String(),
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
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EKOBDailyProductionIndicatorStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(maxLength: 150),
                        IndicatorDate = c.String(),
                        ChokeSize = c.String(),
                        Uptime = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        BSW = c.String(),
                        BHT = c.String(),
                        AnnulusPressure = c.String(),
                        Frequency = c.String(),
                        SAND = c.String(),
                        GROSSAPI = c.String(),
                        NETAPI = c.String(),
                        PS = c.String(),
                        PWF = c.String(),
                        DP = c.String(),
                        OilBOPD = c.String(),
                        WaterBWPD = c.String(),
                        GASMMSCFD = c.String(),
                        PI = c.String(),
                        MaxWaterCut = c.String(),
                        GOR = c.String(),
                        REMARK = c.String(maxLength: 1500),
                        BLPD = c.String(),
                        GASMSCFD = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GasInjectorDailyIndicatorsStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        ChokeSize = c.String(),
                        Uptime = c.String(),
                        Well = c.String(),
                        CompDischPress = c.String(),
                        GasInject = c.String(),
                        IFLP = c.String(),
                        IFLSkinTemp = c.String(),
                        ITHP = c.String(),
                        IBHP = c.String(),
                        IBHT = c.String(),
                        Remark = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorQualityStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        SWLPumpInlet = c.String(),
                        PH = c.String(),
                        ParticlesUpstream = c.String(),
                        ParticlesDownStream = c.String(),
                        Remark = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorRateHeaderStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.String(),
                        TotalWaterInj = c.String(),
                        WIJUptime = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorRateLineItemStagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        IndicatorDate = c.String(),
                        ChokeSize = c.String(),
                        UpTime = c.String(),
                        THIP = c.String(),
                        THSP = c.String(),
                        FLP = c.String(),
                        HP = c.String(),
                        INJRate = c.String(),
                        CumINJRate = c.String(),
                        ReportDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WaterInjectorRateLineItemStagings");
            DropTable("dbo.WaterInjectorRateHeaderStagings");
            DropTable("dbo.WaterInjectorQualityStagings");
            DropTable("dbo.GasInjectorDailyIndicatorsStagings");
            DropTable("dbo.EKOBDailyProductionIndicatorStagings");
            DropTable("dbo.EBOKGasProductionSummaryStagings");
            DropTable("dbo.EBOKFieldProductionSummaryStagings");
            DropTable("dbo.BackAllocationBPLDStagings");
            DropTable("dbo.BackAllocationAssumedGORStagings");
        }
    }
}
