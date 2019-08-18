using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using System.Collections.Generic;

namespace MarketPlace.Entities.Users
{

    public class Seller:User
    {
        public List<Advertisement> Advertisements { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
