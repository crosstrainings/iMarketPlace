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
        public virtual List<Image> Images { get; set; }

        public int BadgeId { get; set; }
        public virtual Badge Badge { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
       // public AdvertisementDetail Detail { get; set; }
    }
}
