namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProcessDataReadings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CFBProcessData_Reading",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        Pressure = c.String(),
                        Temperature = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBProcessData_Reading",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        Pressure = c.String(),
                        Temperature = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WFBProcessData_Reading");
            DropTable("dbo.CFBProcessData_Reading");
        }
    }
}
