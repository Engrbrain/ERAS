namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeDatetoModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FlowParameters", "IndicatorDate", c => c.String());
            AddColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate", c => c.String());
            AddColumn("dbo.WaterInjectorQualities", "IndicatorDate", c => c.String());
            AddColumn("dbo.WaterInjectorRateHeaders", "IndicatorDate", c => c.String());
            AddColumn("dbo.WaterInjectorRateLineItems", "IndicatorDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WaterInjectorRateLineItems", "IndicatorDate");
            DropColumn("dbo.WaterInjectorRateHeaders", "IndicatorDate");
            DropColumn("dbo.WaterInjectorQualities", "IndicatorDate");
            DropColumn("dbo.GasInjectorDailyIndicators", "IndicatorDate");
            DropColumn("dbo.FlowParameters", "IndicatorDate");
        }
    }
}
