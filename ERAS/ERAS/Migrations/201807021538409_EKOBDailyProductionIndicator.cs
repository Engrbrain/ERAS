namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EKOBDailyProductionIndicator : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EKOBDailyProductionIndicators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        IndicatorDate = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        BSW = c.String(),
                        BHT = c.String(),
                        AnnulusPressure = c.String(),
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
                        GOR = c.String(),
                        REMARK = c.String(),
                        BLPD = c.String(),
                        GASMSCFD = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EKOBDailyProductionIndicators");
        }
    }
}
