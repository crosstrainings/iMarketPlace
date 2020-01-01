namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class revertcart : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "AdvertisementId", "dbo.Advertisements");
            DropForeignKey("dbo.Carts", "BuyerId", "dbo.Buyers");
            DropForeignKey("dbo.CartDetails", "Id", "dbo.Carts");
            DropIndex("dbo.Carts", new[] { "AdvertisementId" });
            DropIndex("dbo.Carts", new[] { "BuyerId" });
            DropIndex("dbo.CartDetails", new[] { "Id" });
            DropTable("dbo.Carts");
            DropTable("dbo.CartDetails");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdvertisementId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        CartDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.CartDetails", "Id");
            CreateIndex("dbo.Carts", "BuyerId");
            CreateIndex("dbo.Carts", "AdvertisementId");
            AddForeignKey("dbo.CartDetails", "Id", "dbo.Carts", "Id");
            AddForeignKey("dbo.Carts", "BuyerId", "dbo.Buyers", "Id");
            AddForeignKey("dbo.Carts", "AdvertisementId", "dbo.Advertisements", "Id", cascadeDelete: true);
        }
    }
}
