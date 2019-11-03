using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace iMarketPlace.Web.Models
{
    public static class AdvertisementManager
    {
        public static bool Add(Advertisement advertisement)
        {
            AdvertisementContext db = new AdvertisementContext();
            db.Advertisements.Add(advertisement);
            db.SaveChanges();
            return true;
        }

        public static List<Advertisement> Get()
        {
            AdvertisementContext db = new AdvertisementContext();
            return db.Advertisements.ToList();

            //SELECT 
            //[Extent1].[RegistrationNumber] AS[RegistrationNumber], 
            //    [Extent1].[Title] AS[Title], 
            //    [Extent1].[Price] AS[Price], 
            //    [Extent1].[Category] AS[Category], 
            //    [Extent1].[Image]
            //AS[Image]
            //FROM[dbo].[Advertisements] AS[Extent1]
    }
    }
}
