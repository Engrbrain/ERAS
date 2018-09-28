namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WellUnBlob : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WaterInjectorRateLineItemStagings", "Well", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WaterInjectorRateLineItemStagings", "Well", c => c.String());
        }
    }
}
