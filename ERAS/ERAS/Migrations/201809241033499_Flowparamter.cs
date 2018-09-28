namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Flowparamter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlowParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndicatorDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        FTHP_FLP = c.String(),
                        FlowDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FlowParameters");
        }
    }
}
