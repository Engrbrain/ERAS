namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOilPotential : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WellTestResults", "NETOILPOTENTIAL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WellTestResults", "NETOILPOTENTIAL");
        }
    }
}
