namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewCreateTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EBOKFieldProductionSummaries", "Uptime", c => c.String());
            AddColumn("dbo.EBOKFieldProductionSummaries", "ProdOil", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EBOKFieldProductionSummaries", "ProdOil");
            DropColumn("dbo.EBOKFieldProductionSummaries", "Uptime");
        }
    }
}
