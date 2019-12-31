namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvertisementDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ItemCode = c.String(),
                        Description = c.String(),
                        Discount = c.Double(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ExpiredOn = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Advertisements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Double(nullable: false),
                        BadgeId = c.Int(),
                        CategoryId = c.Int(),
                        SellerId = c.Int(),
                        DetailId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badges", t => t.BadgeId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Sellers", t => t.SellerId)
                .Index(t => t.BadgeId)
                .Index(t => t.CategoryId)
                .Index(t => t.SellerId);
            
            CreateTable(
                "dbo.Badges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Icon_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.Icon_Id)
                .Index(t => t.Icon_Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Height = c.Single(nullable: false),
                        Width = c.Single(nullable: false),
                        Caption = c.String(),
                        Description = c.String(),
                        AdvertisementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.AdvertisementId, cascadeDelete: true)
                .Index(t => t.AdvertisementId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressId = c.Int(),
                        ProfileImageId = c.Int(),
                        CoverImageId = c.Int(),
                        Rank = c.Int(nullable: false),
                        BadgeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId)
                .ForeignKey("dbo.Badges", t => t.BadgeId)
                .ForeignKey("dbo.Images", t => t.CoverImageId)
                .ForeignKey("dbo.Images", t => t.ProfileImageId)
                .Index(t => t.AddressId)
                .Index(t => t.BadgeId)
                .Index(t => t.CoverImageId)
                .Index(t => t.ProfileImageId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        HouseNumber = c.String(),
                        CityId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        Stars = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        IsVisible = c.Boolean(nullable: false),
                        Seller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sellers", t => t.Seller_Id)
                .Index(t => t.Seller_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderCode = c.String(),
                        AdvertisementId = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        ReviewId = c.Int(nullable: false),
                        AdvertisementDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.AdvertisementId, cascadeDelete: true)
                .ForeignKey("dbo.Buyers", t => t.BuyerId)
                .ForeignKey("dbo.Reviews", t => t.ReviewId, cascadeDelete: true)
                .ForeignKey("dbo.AdvertisementDetails", t => t.AdvertisementDetail_Id)
                .Index(t => t.AdvertisementId)
                .Index(t => t.BuyerId)
                .Index(t => t.ReviewId)
                .Index(t => t.AdvertisementDetail_Id);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CanAffliated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
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
