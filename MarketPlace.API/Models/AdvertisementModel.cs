using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketPlace.API.Models
{
    public class AdvertisementModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}