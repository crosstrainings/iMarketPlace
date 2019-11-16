using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MarketPlace.Entities.Advertisements;

namespace MarketPlace.Repositories
{
    public class AdvertisementRepository
    {
        private MarketPlaceContext context;
        public AdvertisementRepository()
        {
            context = new MarketPlaceContext();
        }

        private void Save()
        {
            context.SaveChanges();
        }

        public void Add(Advertisement advertisement)
        {
            context.Advertisements.Add(advertisement);
            context.Entry(advertisement.Category).State = EntityState.Unchanged;
            Save();
        }

        public IList<Advertisement> Get()
        {
            return context.Advertisements.ToList();
        }
        public Advertisement Get(int id)
        {
            // Query Over Collections
            /*
             * - LINQ QUERIES
             * - LINQ EXTENSION METHODS
             */

            Advertisement advertisement = null;
            //LINQ QUERY
            advertisement = (from ad in context.Advertisements 
                             where ad.Id == id 
                             select ad).FirstOrDefault();

            //LINQ EXTENSION 
            //advertisement = context.Advertisements.FirstOrDefault(x => x.Id == id);
            return advertisement;
        }

    }
}