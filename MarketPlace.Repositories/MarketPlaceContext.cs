using System.Data.Entity;
using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Orders;
using MarketPlace.Entities.Payments;
using MarketPlace.Entities.Users;

namespace MarketPlace.Repositories
{
    public class MarketPlaceContext : DbContext
    {
        public MarketPlaceContext() : base("name=iMarketPlaceConn"){}

        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<AdvertisementDetail> AdvertisementDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentMethod>  PaymentMethods { get; set; }
        public DbSet<User>  Users { get; set; }
        public DbSet<Buyer>  Buyers { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}