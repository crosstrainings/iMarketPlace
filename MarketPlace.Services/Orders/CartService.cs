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
        public bool Add(CartAddViewModel cartAddVm)
        {
            var cart = new Cart()
            {
                BuyerId = cartAddVm.BuyerId,
                AdvertisementId = cartAddVm.AdvertisementId,
                CartDetail = new CartDetail()
                {
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    Quantity = cartAddVm.Quantity,
                    TotalAmount = cartAddVm.TotalAmount
                }
            };
            _cartRepository.Add(cart);
            return true;
        }

        public List<CartAddViewModel> Get()
        {
            var cartItems = (List<Cart>)_cartRepository.Get();
            var carts = new List<CartAddViewModel>();
            carts.AddRange(cartItems.Select(x => new CartAddViewModel()
            {
                AdvertisementId = x.AdvertisementId,
                BuyerId = x.BuyerId,
                Id= x.Id,
                Quantity= x.CartDetail.Quantity,
                TotalAmount= x.CartDetail.TotalAmount

            }));
            return carts;
        }
        
        public CartSummaryHolderViewModel GetUserCartItems(int buyerId)
        {
            var cartItems = (List<Cart>)_cartRepository.Get(buyerId);
            var totalCount = _cartRepository.GetCount(buyerId);
            var cartOverview = new CartSummaryHolderViewModel();
            var carts = new List<CartSummaryViewModel>();
            carts.AddRange(cartItems.Select(x => new CartSummaryViewModel()
            {
                Id = x.Id,
                Title = x.Advertisement.Title,
                Thumbnail= x.Advertisement.Images.First().Url,
                Price= x.Advertisement.Price

            }));
            cartOverview.OverViewItems = carts;
            cartOverview.Total = totalCount;
            return cartOverview;
        }
    }
}
