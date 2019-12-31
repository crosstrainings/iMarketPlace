using MarketPlace.Entities.Orders;
using System.Collections.Generic;
using System.Linq;

namespace MarketPlace.Repositories.Orders
{
    public class CartRepository
    {
        private MarketPlaceContext context;
        public CartRepository()
        {
            context = new MarketPlaceContext();
        }
        private void Save()
        {
            context.SaveChanges();
        }
        public void Add(Cart cart)
        {
            context.Carts.Add(cart);
            Save();
        }

        public IList<Cart> Get()
        {
            return context.Carts.OrderByDescending(x => x.Id).ToList();
        }
        public IList<Cart> Get(int buyerId)
        {
            return context.Carts.Where(x => x.BuyerId == buyerId).OrderByDescending(x => x.Id).ToList();
        }

    }
}
