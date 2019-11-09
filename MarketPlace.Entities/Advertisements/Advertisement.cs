using MarketPlace.Entities.Common;
using MarketPlace.Entities.Orders;
using MarketPlace.Entities.Users;
using System;
using System.Collections.Generic;

namespace MarketPlace.Entities.Advertisements
{
    public class Advertisement
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }
        public Badge Badge { get; set; }
        public Category Category { get; set; }
        public Seller Seller { get; set; }
       // public AdvertisementDetail Detail { get; set; }
    }
}
