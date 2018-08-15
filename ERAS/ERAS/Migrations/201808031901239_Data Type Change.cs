namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataTypeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate", c => c.String());
        }
    }
}
