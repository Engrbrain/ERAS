namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePotentialToActual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BackAllocationQgActuals", "QgActual", c => c.Double(nullable: false));
            AddColumn("dbo.BackAllocationQgActualHeaders", "QgActual", c => c.Double(nullable: false));
            AddColumn("dbo.BackAllocationQgActualSummaries", "QgActual", c => c.Double(nullable: false));
            DropColumn("dbo.BackAllocationQgActuals", "QgPotential");
            DropColumn("dbo.BackAllocationQgActualHeaders", "QgPotential");
            DropColumn("dbo.BackAllocationQgActualSummaries", "QgPotential");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BackAllocationQgActualSummaries", "QgPotential", c => c.Double(nullable: false));
            AddColumn("dbo.BackAllocationQgActualHeaders", "QgPotential", c => c.Double(nullable: false));
            AddColumn("dbo.BackAllocationQgActuals", "QgPotential", c => c.Double(nullable: false));
            DropColumn("dbo.BackAllocationQgActualSummaries", "QgActual");
            DropColumn("dbo.BackAllocationQgActualHeaders", "QgActual");
            DropColumn("dbo.BackAllocationQgActuals", "QgActual");
        }
    }
}
