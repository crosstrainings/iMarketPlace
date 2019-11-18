using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Entities.Users
{
    [Table("Sellers")]
    public class Seller:User
    {
        public virtual List<Advertisement> Advertisements { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public bool CanAffliated { get; set; }
    }
}
