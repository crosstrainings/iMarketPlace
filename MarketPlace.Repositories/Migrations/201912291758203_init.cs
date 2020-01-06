namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        { }
       
        
        public override void Down()
        {
            DropForeignKey("dbo.Sellers", "Id", "dbo.Users");
            DropForeignKey("dbo.Buyers", "Id", "dbo.Users");
            DropForeignKey("dbo.Users", "ProfileImageId", "dbo.Images");
            DropForeignKey("dbo.Users", "CoverImageId", "dbo.Images");
            DropForeignKey("dbo.Users", "BadgeId", "dbo.Badges");
            DropForeignKey("dbo.Users", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Orders", "AdvertisementDetail_Id", "dbo.AdvertisementDetails");
            DropForeignKey("dbo.Orders", "ReviewId", "dbo.Reviews");
            DropForeignKey("dbo.Orders", "BuyerId", "dbo.Buyers");
            DropForeignKey("dbo.Orders", "AdvertisementId", "dbo.Advertisements");
            DropForeignKey("dbo.AdvertisementDetails", "Id", "dbo.Advertisements");
            DropForeignKey("dbo.Reviews", "Seller_Id", "dbo.Sellers");
            DropForeignKey("dbo.Advertisements", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Advertisements", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.Advertisements", "BadgeId", "dbo.Badges");
            DropForeignKey("dbo.Badges", "Icon_Id", "dbo.Images");
            DropForeignKey("dbo.Images", "AdvertisementId", "dbo.Advertisements");
            DropIndex("dbo.Sellers", new[] { "Id" });
            DropIndex("dbo.Buyers", new[] { "Id" });
            DropIndex("dbo.Users", new[] { "ProfileImageId" });
            DropIndex("dbo.Users", new[] { "CoverImageId" });
            DropIndex("dbo.Users", new[] { "BadgeId" });
            DropIndex("dbo.Users", new[] { "AddressId" });
            DropIndex("dbo.Orders", new[] { "AdvertisementDetail_Id" });
            DropIndex("dbo.Orders", new[] { "ReviewId" });
            DropIndex("dbo.Orders", new[] { "BuyerId" });
            DropIndex("dbo.Orders", new[] { "AdvertisementId" });
            DropIndex("dbo.AdvertisementDetails", new[] { "Id" });
            DropIndex("dbo.Reviews", new[] { "Seller_Id" });
            DropIndex("dbo.Advertisements", new[] { "SellerId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropIndex("dbo.Advertisements", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "SubCategoryId" });
            DropIndex("dbo.Advertisements", new[] { "BadgeId" });
            DropIndex("dbo.Badges", new[] { "Icon_Id" });
            DropIndex("dbo.Images", new[] { "AdvertisementId" });
            DropTable("dbo.Sellers");
            DropTable("dbo.Buyers");
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.Orders");
            DropTable("dbo.Reviews");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
            DropTable("dbo.Users");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Images");
            DropTable("dbo.Badges");
            DropTable("dbo.Advertisements");
            DropTable("dbo.AdvertisementDetails");
        }
    }
}
