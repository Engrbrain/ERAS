namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EBOKGasProductionSummaries", "CFBGasLift", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EBOKGasProductionSummaries", "CFBGasLift");
        }
    }
}
