namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OutputDataModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EBOKInjectivityIndexViewModels", newName: "EBOKInjectivityIndexes");
            RenameTable(name: "dbo.FlowParameters", newName: "BackAllocationAssumedGORs");
            CreateTable(
                "dbo.BackAllocationActualGORs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        ActualGOR = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationActualGORHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        ActualGOR = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationActualGORSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        ActualGOR = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationBOPDs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        BOPD = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationBSWs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        BSW = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationFlowHRS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        Uptime = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationGasAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        GasAllocation = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationGasAllocationHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        GasAllocation = c.Double(nullable: false),
                        ActualGasProduced = c.Double(nullable: false),
                        GasDifference = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationGasAllocationSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        GasAllocation = c.Double(nullable: false),
                        ActualGasProduced = c.Double(nullable: false),
                        GasDifference = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQgPotentials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQgPotentialHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQgPotentialSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQlests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        Qlest = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQlinkSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        ProdOil = c.Double(nullable: false),
                        TotalQlink = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        Qo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        Qoest = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoestHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        ProdOil = c.Double(nullable: false),
                        wellTestPotential = c.Double(nullable: false),
                        WellTestActual = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoestSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        ProdOil = c.Double(nullable: false),
                        wellTestPotential = c.Double(nullable: false),
                        WellTestActual = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Qo = c.Double(nullable: false),
                        ProdOil = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQoSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        Qo = c.Double(nullable: false),
                        ProdOil = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQws",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        Qw = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQwHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Qw = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQwSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        Qw = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKHallPlotDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        IndicatorDate = c.DateTime(nullable: false),
                        BWPD = c.Double(nullable: false),
                        CUMMMBBL = c.Double(nullable: false),
                        FTHP = c.Double(nullable: false),
                        THSP = c.Double(nullable: false),
                        DTDays = c.Double(nullable: false),
                        II = c.Double(nullable: false),
                        HallCal = c.Double(nullable: false),
                        HallCal2 = c.Double(nullable: false),
                        HallCal3 = c.Double(nullable: false),
                        HallCal4 = c.Double(nullable: false),
                        Hall = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EBOKProductionSurveillances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        IndicatorDate = c.DateTime(nullable: false),
                        BSW = c.Double(nullable: false),
                        OilBOPD = c.Double(nullable: false),
                        GASMSCFD = c.Double(nullable: false),
                        CumOil = c.Double(nullable: false),
                        CumOilkbbls = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GasTrends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        WFBPROCESSTOTAL = c.Double(nullable: false),
                        TOTALGasLift = c.Double(nullable: false),
                        CalcuatedInjectedGas = c.Double(nullable: false),
                        MeteredGasInjected = c.Double(nullable: false),
                        GASUtilizationTotal = c.Double(nullable: false),
                        GASFLAREDTOTAL = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PressurePlotTCMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        RSV = c.String(),
                        Well = c.String(),
                        PWF = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BackAllocationAssumedGORs", "AssumedGOR", c => c.Double(nullable: false));
            DropColumn("dbo.BackAllocationAssumedGORs", "FTHP");
            DropColumn("dbo.BackAllocationAssumedGORs", "FlowDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BackAllocationAssumedGORs", "FlowDescription", c => c.String());
            AddColumn("dbo.BackAllocationAssumedGORs", "FTHP", c => c.String());
            DropColumn("dbo.BackAllocationAssumedGORs", "AssumedGOR");
            DropTable("dbo.PressurePlotTCMs");
            DropTable("dbo.GasTrends");
            DropTable("dbo.EBOKProductionSurveillances");
            DropTable("dbo.EBOKHallPlotDatas");
            DropTable("dbo.BackAllocationQwSummaries");
            DropTable("dbo.BackAllocationQwHeaders");
            DropTable("dbo.BackAllocationQws");
            DropTable("dbo.BackAllocationQoSummaries");
            DropTable("dbo.BackAllocationQoHeaders");
            DropTable("dbo.BackAllocationQoestSummaries");
            DropTable("dbo.BackAllocationQoestHeaders");
            DropTable("dbo.BackAllocationQoests");
            DropTable("dbo.BackAllocationQoes");
            DropTable("dbo.BackAllocationQlinkSummaries");
            DropTable("dbo.BackAllocationQlests");
            DropTable("dbo.BackAllocationQgPotentialSummaries");
            DropTable("dbo.BackAllocationQgPotentialHeaders");
            DropTable("dbo.BackAllocationQgPotentials");
            DropTable("dbo.BackAllocationGasAllocationSummaries");
            DropTable("dbo.BackAllocationGasAllocationHeaders");
            DropTable("dbo.BackAllocationGasAllocations");
            DropTable("dbo.BackAllocationFlowHRS");
            DropTable("dbo.BackAllocationBSWs");
            DropTable("dbo.BackAllocationBOPDs");
            DropTable("dbo.BackAllocationActualGORSummaries");
            DropTable("dbo.BackAllocationActualGORHeaders");
            DropTable("dbo.BackAllocationActualGORs");
            RenameTable(name: "dbo.BackAllocationAssumedGORs", newName: "FlowParameters");
            RenameTable(name: "dbo.EBOKInjectivityIndexes", newName: "EBOKInjectivityIndexViewModels");
        }
    }
}
