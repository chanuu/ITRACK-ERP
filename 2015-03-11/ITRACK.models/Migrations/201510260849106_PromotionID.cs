namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromotionID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Promotions");
            AlterColumn("dbo.Promotions", "PromotionID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Promotions", "PromotionID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Promotions");
            AlterColumn("dbo.Promotions", "PromotionID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Promotions", "PromotionID");
        }
    }
}
