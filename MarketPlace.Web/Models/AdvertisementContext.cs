using System.Data.Entity;

namespace iMarketPlace.Web.Models
{
    //Inherit from DbContext


    public class AdvertisementContext : DbContext
    {
        public AdvertisementContext() : base("name=iMarketPlaceConn")
        {

        }


        //Fluent API 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Advertisement>().HasKey(x => x.RegistrationNumber);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Advertisement> Advertisements { get; set; }


    }
}