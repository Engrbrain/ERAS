namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CFBGasCompression_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CFBGasCompressions", "Parameter", c => c.String());
            AddColumn("dbo.CFBGasCompressions", "ParameterValue", c => c.String());
            DropColumn("dbo.CFBGasCompressions", "SuctionPressure");
            DropColumn("dbo.CFBGasCompressions", "DischargePressure");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CFBGasCompressions", "DischargePressure", c => c.String());
            AddColumn("dbo.CFBGasCompressions", "SuctionPressure", c => c.String());
            DropColumn("dbo.CFBGasCompressions", "ParameterValue");
            DropColumn("dbo.CFBGasCompressions", "Parameter");
        }
    }
}
