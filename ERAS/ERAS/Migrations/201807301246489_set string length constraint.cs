namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setstringlengthconstraint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Uptime", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "THP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "FLP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BSW", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHT", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "AnnulusPressure", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Frequency", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "SAND", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GROSSAPI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "NETAPI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PS", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PWF", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "DP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "OilBOPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "WaterBWPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMMSCFD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHP", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PI", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GOR", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "REMARK", c => c.String(maxLength: 500));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BLPD", c => c.String(maxLength: 50));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMSCFD", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMSCFD", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BLPD", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "REMARK", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GOR", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PI", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHP", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GASMMSCFD", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "WaterBWPD", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "OilBOPD", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "DP", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PWF", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "PS", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "NETAPI", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "GROSSAPI", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "SAND", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Frequency", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "AnnulusPressure", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BHT", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "BSW", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "FLP", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "THP", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Uptime", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "ChokeSize", c => c.String());
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.String(maxLength: 80));
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String(maxLength: 80));
        }
    }
}
