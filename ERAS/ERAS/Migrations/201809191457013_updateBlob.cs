namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBlob : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WaterInjectorRateLineItems", "Well", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WaterInjectorRateLineItems", "Well", c => c.String());
        }
    }
}
