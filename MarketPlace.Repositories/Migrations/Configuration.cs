namespace MarketPlace.Repositories.Migrations
{
    using MarketPlace.Entities.Advertisements;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MarketPlace.Repositories.MarketPlaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MarketPlace.Repositories.MarketPlaceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            if (!context.SubCategories.Any())
            {
                context.SubCategories.AddOrUpdate(
                  p => p.Id,
                  new SubCategory() { Name = "Temp", Id = 1 }
                );
                context.Categories.AddOrUpdate(
                p => p.Id,
                new Category() { Id = 1, Name = "Vehicle", CreatedOn = DateTime.Now, SubCategoryId = 1 },
                new Category() { Id = 2, Name = "Electronics", CreatedOn = DateTime.Now, SubCategoryId = 1 },
                new Category() { Id = 3, Name = "Sports", CreatedOn = DateTime.Now, SubCategoryId = 1 },
                new Category() { Id = 4, Name = "Fitness", CreatedOn = DateTime.Now, SubCategoryId = 1 },
                new Category() { Id = 5, Name = "Clothes", CreatedOn = DateTime.Now, SubCategoryId = 1 }

              );
            }
        }
    }
}
