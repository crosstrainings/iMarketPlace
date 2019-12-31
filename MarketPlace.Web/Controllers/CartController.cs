using MarketPlace.Services.Orders;
using MarketPlace.ViewModels.Orders;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;

        // GET: Cart
        public CartController()
        {
            _cartService = new CartService();
        }
        public ActionResult Summary()
        {
            return PartialView("_CartSummary");
        }
        public ActionResult Add(CartViewModel cart)
        {
            _cartService.Add(cart);
            return Json(true,JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult UserCart(int buyerId)
        {
            var cartItems = _cartService.GetUserCartItems(buyerId);
            return PartialView("_CartItem", cartItems);
        }
    }
}