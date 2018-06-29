namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CFBWellEnrichmentData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OperationsSummaries", "OperationsReport", c => c.String());
            DropColumn("dbo.OperationsSummaries", "DownTimeReport");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OperationsSummaries", "DownTimeReport", c => c.String());
            DropColumn("dbo.OperationsSummaries", "OperationsReport");
        }
    }
}
