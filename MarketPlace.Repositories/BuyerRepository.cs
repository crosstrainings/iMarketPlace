using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Users;

namespace MarketPlace.Repositories
{
    public class BuyerRepository
    {
        private MarketPlaceContext context;
        public BuyerRepository()
        {
            context = new MarketPlaceContext();
        }

        private void Save()
        {
            context.SaveChanges();
        }

        public void Add(Buyer buyer)
        {
            context.Buyers.Add(buyer);
            Save();
        }

        public IList<Buyer> Get()
        {
            return context.Buyers.ToList();
        }
    }
}