using System.Collections.Generic;

namespace iMarketPlace.Web.Models
{
    public static class AdvertisementManager
    {
        private static List<Advertisement> advertisements { get; set; }
        static AdvertisementManager()
        {
            advertisements = new List<Advertisement>();
        }


        public static bool Add(Advertisement advertisement)
        {
            if (advertisement.Category > 0 && advertisement.Image.Length > 0 && advertisement.Title.Length > 0 && advertisement.Price.Length > 0)
            {
                advertisements.Add(advertisement);
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public static List<Advertisement> Get()
        {
            return advertisements;
        }
    }
}
