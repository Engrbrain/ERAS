namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QlinkDataModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackAllocationQlinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        Well = c.Double(nullable: false),
                        Qlink = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BackAllocationQlinkHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        ProdOil = c.Double(nullable: false),
                        TotalQlink = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BackAllocationQlinkHeaders");
            DropTable("dbo.BackAllocationQlinks");
        }
    }
}
