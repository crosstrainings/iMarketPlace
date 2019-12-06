namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvertUpdatedWithItemCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdvertisementDetails", "ItemCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdvertisementDetails", "ItemCode");
        }
    }
}
