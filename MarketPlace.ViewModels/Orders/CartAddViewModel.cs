using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ViewModels.Orders
{
    public class CartAddViewModel
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public int BuyerId { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
    }
}
