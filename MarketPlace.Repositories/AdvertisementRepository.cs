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
            Save();
        }

        public IList<Advertisement> Get()
        {
            return context.Advertisements.OrderByDescending(x => x.Id).ToList();
        }
        public Advertisement Get(string code)
        {
            Advertisement advertisement = null;
            advertisement = (from ad in context.Advertisements
                             where ad.Detail.ItemCode.Equals(code)
                             select ad).FirstOrDefault();
            return advertisement;
        }
        public Advertisement Get(int id)
        {
            Advertisement advertisement = null;
            advertisement = (from ad in context.Advertisements
                             where ad.Id == id
                             select ad).FirstOrDefault();
            return advertisement;
        }

        public IList<Advertisement> GetSellerAds(int userId)
        {
            return (from ad in context.Advertisements
                    where ad.SellerId == userId
                    select ad).ToList();
        }

    }
}