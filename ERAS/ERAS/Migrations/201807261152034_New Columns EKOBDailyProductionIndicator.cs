namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnsEKOBDailyProductionIndicator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EKOBDailyProductionIndicators", "BHP", c => c.String());
            AddColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EKOBDailyProductionIndicators", "MaxWaterCut");
            DropColumn("dbo.EKOBDailyProductionIndicators", "BHP");
        }
    }
}
