using System.Data.Entity;

namespace iMarketPlace.Web.Models
{
    //Inherit from DbContext


    public class AdvertisementContext : DbContext
    {
        public AdvertisementContext() : base("name=iMarketPlaceConn")
        {
            //Data Loading 
            //1: Lazy Loading - By Default TRUE
            //2: Eager Loading
            //3: Explicit Loading
            base.Configuration.LazyLoadingEnabled = false;
        }


        //Fluent API 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Advertisement>().HasKey(x => x.RegistrationNumber)
            //                                    .HasRequired(x => x.Title);
            //modelBuilder.Entity<Advertisement>().Property(x=>x.Title).HasMaxLength(100);
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}