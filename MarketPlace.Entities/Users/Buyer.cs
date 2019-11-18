using MarketPlace.Entities.Orders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Entities.Users
{
    [Table("Buyers")]
    public class Buyer:User
    {
        public List<Order> Orders { get; set; }
    }
}
