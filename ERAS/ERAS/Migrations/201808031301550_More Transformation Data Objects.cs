namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreTransformationDataObjects : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WaterInjectorRateLineItems", "Well", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WaterInjectorRateLineItems", "Well");
        }
    }
}
