namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveWellfromQlest : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BackAllocationQlestHeaders", "Well");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BackAllocationQlestHeaders", "Well", c => c.String());
        }
    }
}
