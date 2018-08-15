namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BackAllocationQgActual : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackAllocationQgActuals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.String(),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQgActualHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQgActualSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        QgPotential = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BackAllocationQgActualSummaries");
            DropTable("dbo.BackAllocationQgActualHeaders");
            DropTable("dbo.BackAllocationQgActuals");
        }
    }
}
