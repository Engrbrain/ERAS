namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFlowParameter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FlowParameters", "Well", c => c.String());
            AlterColumn("dbo.FlowParameters", "FTHP_FLP", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FlowParameters", "FTHP_FLP", c => c.String());
            DropColumn("dbo.FlowParameters", "Well");
        }
    }
}
