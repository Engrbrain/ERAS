namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EKOBDailyProductionIndicatorremoveBlob : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "Well", c => c.String());
        }
    }
}
