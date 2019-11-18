using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Users;

namespace MarketPlace.Repositories
{
    public class SellerRepository
    {
        private MarketPlaceContext context;
        public SellerRepository()
        {
            context = new MarketPlaceContext();
        }

        private void Save()
        {
            context.SaveChanges();
        }

        public void Add(Seller seller)
        {
            context.Sellers.Add(seller);
            Save();
        }

        public IList<Seller> Get()
        {
            return context.Sellers.ToList();
        }
        
    }
}