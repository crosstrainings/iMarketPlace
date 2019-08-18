using MarketPlace.Entities.Orders;
using System.Collections.Generic;

namespace MarketPlace.Entities.Users
{
    public class Buyer:User
    {
        public List<Order> Orders { get; set; }
    }
}
