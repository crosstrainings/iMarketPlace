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
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Discount = c.Double(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ExpiredOn = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Rank = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderCode = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Advertisement_Id = c.Int(),
                        Buyer_Id = c.Int(),
                        Review_Id = c.Int(),
                        AdvertisementDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.Advertisement_Id)
                .ForeignKey("dbo.Users", t => t.Buyer_Id)
                .ForeignKey("dbo.Reviews", t => t.Review_Id)
                .ForeignKey("dbo.AdvertisementDetails", t => t.AdvertisementDetail_Id)
                .Index(t => t.Advertisement_Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Review_Id)
                .Index(t => t.AdvertisementDetail_Id);
            
            CreateTable(
                "dbo.Advertisements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Price = c.Double(nullable: false),
                        Badge_Id = c.Int(),
                        Category_Id = c.Int(),
                        Seller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badges", t => t.Badge_Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Users", t => t.Seller_Id)
                .Index(t => t.Badge_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Seller_Id);
            
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
                        Advertisement_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Advertisements", t => t.Advertisement_Id)
                .Index(t => t.Advertisement_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        SubCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategory_Id)
                .Index(t => t.SubCategory_Id);
            
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
                        Rank = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Address_Id = c.Int(),
                        Badge_Id = c.Int(),
                        CoverImage_Id = c.Int(),
                        ProfileImage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.Badges", t => t.Badge_Id)
                .ForeignKey("dbo.Images", t => t.CoverImage_Id)
                .ForeignKey("dbo.Images", t => t.ProfileImage_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Badge_Id)
                .Index(t => t.CoverImage_Id)
                .Index(t => t.ProfileImage_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        HouseNumber = c.String(),
                        City_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
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
                .ForeignKey("dbo.Users", t => t.Seller_Id)
                .Index(t => t.Seller_Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ProfileImage_Id", "dbo.Images");
            DropForeignKey("dbo.Users", "CoverImage_Id", "dbo.Images");
            DropForeignKey("dbo.Users", "Badge_Id", "dbo.Badges");
            DropForeignKey("dbo.Users", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Orders", "AdvertisementDetail_Id", "dbo.AdvertisementDetails");
            DropForeignKey("dbo.Orders", "Review_Id", "dbo.Reviews");
            DropForeignKey("dbo.Orders", "Buyer_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "Advertisement_Id", "dbo.Advertisements");
            DropForeignKey("dbo.Reviews", "Seller_Id", "dbo.Users");
            DropForeignKey("dbo.Advertisements", "Seller_Id", "dbo.Users");
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Images", "Advertisement_Id", "dbo.Advertisements");
            DropForeignKey("dbo.Advertisements", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.Advertisements", "Badge_Id", "dbo.Badges");
            DropForeignKey("dbo.Badges", "Icon_Id", "dbo.Images");
            DropIndex("dbo.Users", new[] { "ProfileImage_Id" });
            DropIndex("dbo.Users", new[] { "CoverImage_Id" });
            DropIndex("dbo.Users", new[] { "Badge_Id" });
            DropIndex("dbo.Users", new[] { "Address_Id" });
            DropIndex("dbo.Orders", new[] { "AdvertisementDetail_Id" });
            DropIndex("dbo.Orders", new[] { "Review_Id" });
            DropIndex("dbo.Orders", new[] { "Buyer_Id" });
            DropIndex("dbo.Orders", new[] { "Advertisement_Id" });
            DropIndex("dbo.Reviews", new[] { "Seller_Id" });
            DropIndex("dbo.Advertisements", new[] { "Seller_Id" });
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropIndex("dbo.Addresses", new[] { "City_Id" });
            DropIndex("dbo.Images", new[] { "Advertisement_Id" });
            DropIndex("dbo.Advertisements", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "SubCategory_Id" });
            DropIndex("dbo.Advertisements", new[] { "Badge_Id" });
            DropIndex("dbo.Badges", new[] { "Icon_Id" });
            DropTable("dbo.PaymentMethods");
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
            DropTable("dbo.Orders");
            DropTable("dbo.AdvertisementDetails");
        }
    }
}
