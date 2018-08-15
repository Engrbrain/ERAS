namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EKOBDailyProductionIndicators", "IndicatorDate", c => c.String());
        }
    }
}
