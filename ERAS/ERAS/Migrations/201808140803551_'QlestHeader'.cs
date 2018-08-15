namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QlestHeader : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BackAllocationQlestHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false),
                        FaultBlock = c.String(),
                        RSV = c.String(),
                        Well = c.String(),
                        Qlest = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BackAllocationQlestHeaders");
        }
    }
}
