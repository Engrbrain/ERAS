namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLernght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EBOKGasProductionSummaries", "IndicatorDate", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EBOKGasProductionSummaries", "IndicatorDate", c => c.String());
        }
    }
}
