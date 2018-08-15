namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTransformData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlowParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        FTHP = c.String(),
                        FlowDescription = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GasInjectorDailyIndicators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChokeSize = c.String(),
                        Uptime = c.String(),
                        FlowDescription = c.String(),
                        CompDischPress = c.String(),
                        GasInject = c.String(),
                        IFLP = c.String(),
                        IFLSkinTemp = c.String(),
                        ITHP = c.String(),
                        IBHP = c.String(),
                        IBHT = c.String(),
                        Remark = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorQualities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SWLPumpInlet = c.String(),
                        PH = c.String(),
                        ParticlesUpstream = c.String(),
                        ParticlesDownStream = c.String(),
                        Remark = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorRateHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalWaterInj = c.String(),
                        WIJUptime = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WaterInjectorRateLineItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChokeSize = c.String(),
                        UpTime = c.String(),
                        THIP = c.String(),
                        FLP = c.String(),
                        HP = c.String(),
                        INJRate = c.String(),
                        CumINJRate = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize", c => c.String());
            AddColumn("dbo.EKOBDailyProductionIndicators", "Uptime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EKOBDailyProductionIndicators", "Uptime");
            DropColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize");
            DropTable("dbo.WaterInjectorRateLineItems");
            DropTable("dbo.WaterInjectorRateHeaders");
            DropTable("dbo.WaterInjectorQualities");
            DropTable("dbo.GasInjectorDailyIndicators");
            DropTable("dbo.FlowParameters");
        }
    }
}
