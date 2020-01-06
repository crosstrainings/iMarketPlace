using System.Collections;
using System.Collections.Generic;

namespace MarketPlace.ViewModels.Orders
{
    public class CartSummaryHolderViewModel
    {
        public IEnumerable<CartSummaryViewModel> OverViewItems  { get; set; }
        public int Total { get; set; }
    }
   public class CartSummaryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
    }
}
