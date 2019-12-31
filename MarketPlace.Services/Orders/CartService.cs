using MarketPlace.Entities.Orders;
using MarketPlace.Repositories.Orders;
using MarketPlace.ViewModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services.Orders
{
    public class CartService
    {
        private readonly CartRepository _cartRepository;
        public CartService()
        {
            _cartRepository = new CartRepository();
        }
        public bool Add(CartViewModel cartVM)
        {
            var cart = new Cart()
            {
                BuyerId = cartVM.BuyerId,
                AdvertisementId = cartVM.AdvertisementId,
                CartDetail = new CartDetail()
                {
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Quantity = cartVM.Quantity,
                    TotalAmount = cartVM.TotalAmount
                }
            };
            _cartRepository.Add(cart);
            return true;
        }

        public List<CartViewModel> Get()
        {
            var cartItems = (List<Cart>)_cartRepository.Get();
            var carts = new List<CartViewModel>();
            carts.AddRange(cartItems.Select(x => new CartViewModel()
            {
                AdvertisementId = x.AdvertisementId,
                BuyerId = x.BuyerId,
                Id= x.Id,
                Quantity= x.CartDetail.Quantity,
                TotalAmount= x.CartDetail.TotalAmount

            }));
            return carts;
        }
        
        public List<CartViewModel> GetUserCartItems(int buyerId)
        {
            var cartItems = (List<Cart>)_cartRepository.Get(buyerId);
            var carts = new List<CartViewModel>();
            carts.AddRange(cartItems.Select(x => new CartViewModel()
            {
                AdvertisementId = x.AdvertisementId,
                BuyerId = x.BuyerId,
                Id= x.Id,
                Quantity= x.CartDetail.Quantity,
                TotalAmount= x.CartDetail.TotalAmount

            }));
            return carts;
        }
    }
}
