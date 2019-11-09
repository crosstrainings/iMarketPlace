using System.Collections.Generic;
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
