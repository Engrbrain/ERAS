namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productionpotential : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductionPotentials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        GrossLiquid = c.String(),
                        Oil = c.String(),
                        Gas = c.String(),
                        Water = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductionPotentials");
        }
    }
}
