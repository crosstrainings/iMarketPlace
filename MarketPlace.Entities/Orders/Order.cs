using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using MarketPlace.Common.Enums;
using System;

namespace MarketPlace.Entities.Orders
{

    public class Order
    {
        public int Id { get; set; }

        public string OrderCode { get; set; }
        public Advertisement Advertisement { get; set; }
        public  Buyer Buyer { get; set; }
        public DateTime CreatedOn { get; set; }
        public OrderStatus Status { get; set; }
        public Priority Priority { get; set; }
        public double TotalPrice { get; set; }
        public Review Review { get; set; }
    }
}
