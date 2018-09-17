namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCFBCrude : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReportParameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.CFBCrudeExportMeters", "BSW", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CFBCrudeExportMeters", "BSW", c => c.DateTime(nullable: false));
            DropTable("dbo.ReportParameters");
        }
    }
}
