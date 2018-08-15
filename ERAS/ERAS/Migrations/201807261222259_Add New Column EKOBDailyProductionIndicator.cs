namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewColumnEKOBDailyProductionIndicator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EKOBDailyProductionIndicators", "Frequency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EKOBDailyProductionIndicators", "Frequency");
        }
    }
}
