namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateWellDataSchema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CFBWellDatas", "HOURS_Online", c => c.String());
            AddColumn("dbo.CFBWellDatas", "HOURS_Offline", c => c.String());
            AddColumn("dbo.WFBWellDatas", "HOURS_Online", c => c.String());
            AddColumn("dbo.WFBWellDatas", "HOURS_Offline", c => c.String());
            DropColumn("dbo.CFBWellDatas", "HOURS");
            DropColumn("dbo.WFBWellDatas", "HOURS");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WFBWellDatas", "HOURS", c => c.String());
            AddColumn("dbo.CFBWellDatas", "HOURS", c => c.String());
            DropColumn("dbo.WFBWellDatas", "HOURS_Offline");
            DropColumn("dbo.WFBWellDatas", "HOURS_Online");
            DropColumn("dbo.CFBWellDatas", "HOURS_Offline");
            DropColumn("dbo.CFBWellDatas", "HOURS_Online");
        }
    }
}
