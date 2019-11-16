using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using System.Collections.Generic;

namespace MarketPlace.Entities.Users
{

    public class Seller:User
    {
        public virtual List<Advertisement> Advertisements { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
