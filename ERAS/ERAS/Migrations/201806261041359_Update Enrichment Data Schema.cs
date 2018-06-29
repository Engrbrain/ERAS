namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEnrichmentDataSchema : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WellTestEnrichmentDatas", "Well", c => c.String(maxLength: 15));
            AlterColumn("dbo.WellTestEnrichmentDatas", "Rsv", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WellTestEnrichmentDatas", "Rsv", c => c.String());
            AlterColumn("dbo.WellTestEnrichmentDatas", "Well", c => c.String());
        }
    }
}
