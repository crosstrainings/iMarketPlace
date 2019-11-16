namespace MarketPlace.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class navigationpropertiesupdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advertisements", "Badge_Id", "dbo.Badges");
            DropForeignKey("dbo.Categories", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.Advertisements", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Advertisements", "Seller_Id", "dbo.Users");
            DropForeignKey("dbo.Images", "Advertisement_Id", "dbo.Advertisements");
            DropIndex("dbo.Advertisements", new[] { "Badge_Id" });
            DropIndex("dbo.Categories", new[] { "SubCategory_Id" });
            DropIndex("dbo.Advertisements", new[] { "Category_Id" });
            DropIndex("dbo.Advertisements", new[] { "Seller_Id" });
            DropIndex("dbo.Images", new[] { "Advertisement_Id" });
            RenameColumn(table: "dbo.Advertisements", name: "Badge_Id", newName: "BadgeId");
            RenameColumn(table: "dbo.Categories", name: "SubCategory_Id", newName: "SubCategoryId");
            RenameColumn(table: "dbo.Advertisements", name: "Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Advertisements", name: "Seller_Id", newName: "SellerId");
            AddColumn("dbo.Images", "AdvertisementId", c => c.Int(nullable: false));
            AlterColumn("dbo.Advertisements", "BadgeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Advertisements", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Advertisements", "SellerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "SubCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Advertisements", "BadgeId");
            CreateIndex("dbo.Categories", "SubCategoryId");
            CreateIndex("dbo.Advertisements", "CategoryId");
            CreateIndex("dbo.Advertisements", "SellerId");
            CreateIndex("dbo.Images", "AdvertisementId");
            AddForeignKey("dbo.Advertisements", "BadgeId", "dbo.Badges", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "SubCategoryId", "dbo.SubCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Advertisements", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Advertisements", "SellerId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Images", "AdvertisementId", "dbo.Advertisements", "Id", cascadeDelete: true);
            DropColumn("dbo.Images", "Advertisement_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "Advertisement_Id", c => c.Int());
            DropForeignKey("dbo.Images", "AdvertisementId", "dbo.Advertisements");
            DropForeignKey("dbo.Advertisements", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Advertisements", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.Advertisements", "BadgeId", "dbo.Badges");
            DropIndex("dbo.Images", new[] { "AdvertisementId" });
            DropIndex("dbo.Advertisements", new[] { "SellerId" });
            DropIndex("dbo.Advertisements", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "SubCategoryId" });
            DropIndex("dbo.Advertisements", new[] { "BadgeId" });
            AlterColumn("dbo.Categories", "SubCategoryId", c => c.Int());
            AlterColumn("dbo.Advertisements", "SellerId", c => c.Int());
            AlterColumn("dbo.Advertisements", "CategoryId", c => c.Int());
            AlterColumn("dbo.Advertisements", "BadgeId", c => c.Int());
            DropColumn("dbo.Images", "AdvertisementId");
            RenameColumn(table: "dbo.Advertisements", name: "SellerId", newName: "Seller_Id");
            RenameColumn(table: "dbo.Advertisements", name: "CategoryId", newName: "Category_Id");
            RenameColumn(table: "dbo.Categories", name: "SubCategoryId", newName: "SubCategory_Id");
            RenameColumn(table: "dbo.Advertisements", name: "BadgeId", newName: "Badge_Id");
            CreateIndex("dbo.Images", "Advertisement_Id");
            CreateIndex("dbo.Advertisements", "Seller_Id");
            CreateIndex("dbo.Advertisements", "Category_Id");
            CreateIndex("dbo.Categories", "SubCategory_Id");
            CreateIndex("dbo.Advertisements", "Badge_Id");
            AddForeignKey("dbo.Images", "Advertisement_Id", "dbo.Advertisements", "Id");
            AddForeignKey("dbo.Advertisements", "Seller_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Advertisements", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Categories", "SubCategory_Id", "dbo.SubCategories", "Id");
            AddForeignKey("dbo.Advertisements", "Badge_Id", "dbo.Badges", "Id");
        }
    }
}
