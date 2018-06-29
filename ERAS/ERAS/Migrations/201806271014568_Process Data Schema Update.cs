namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProcessDataSchemaUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CFBProcessData_GasConsumed", "GasFlowParameter", c => c.String());
            AddColumn("dbo.WFBProcessData_GasConsumed", "GasFlowParameter", c => c.String());
            DropColumn("dbo.CFBProcessData_GasConsumed", "GasSource");
            DropColumn("dbo.CFBProcessData_GasProduced", "GasSource");
            DropColumn("dbo.CFBProcessData_GasProduced", "Pressure");
            DropColumn("dbo.CFBProcessData_GasProduced", "Temperature");
            DropColumn("dbo.WFBProcessData_GasConsumed", "GasSource");
            DropColumn("dbo.WFBProcessData_GasProduced", "GasSource");
            DropColumn("dbo.WFBProcessData_GasProduced", "Pressure");
            DropColumn("dbo.WFBProcessData_GasProduced", "Temperature");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WFBProcessData_GasProduced", "Temperature", c => c.String());
            AddColumn("dbo.WFBProcessData_GasProduced", "Pressure", c => c.String());
            AddColumn("dbo.WFBProcessData_GasProduced", "GasSource", c => c.String());
            AddColumn("dbo.WFBProcessData_GasConsumed", "GasSource", c => c.String());
            AddColumn("dbo.CFBProcessData_GasProduced", "Temperature", c => c.String());
            AddColumn("dbo.CFBProcessData_GasProduced", "Pressure", c => c.String());
            AddColumn("dbo.CFBProcessData_GasProduced", "GasSource", c => c.String());
            AddColumn("dbo.CFBProcessData_GasConsumed", "GasSource", c => c.String());
            DropColumn("dbo.WFBProcessData_GasConsumed", "GasFlowParameter");
            DropColumn("dbo.CFBProcessData_GasConsumed", "GasFlowParameter");
        }
    }
}
