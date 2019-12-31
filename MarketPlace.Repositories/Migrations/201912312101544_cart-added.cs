namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdvertisementId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        CartDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.AdvertisementId, cascadeDelete: true)
                .ForeignKey("dbo.Buyers", t => t.BuyerId)
                .Index(t => t.AdvertisementId)
                .Index(t => t.BuyerId);
            
            CreateTable(
                "dbo.CartDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartDetails", "Id", "dbo.Carts");
            DropForeignKey("dbo.Carts", "BuyerId", "dbo.Buyers");
            DropForeignKey("dbo.Carts", "AdvertisementId", "dbo.Advertisements");
            DropIndex("dbo.CartDetails", new[] { "Id" });
            DropIndex("dbo.Carts", new[] { "BuyerId" });
            DropIndex("dbo.Carts", new[] { "AdvertisementId" });
            DropTable("dbo.CartDetails");
            DropTable("dbo.Carts");
        }
    }
}
