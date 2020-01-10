using System.Collections.Generic;
using MarketPlace.Services.Orders;
using MarketPlace.ViewModels.Orders;
using System.Web.Mvc;
using iMarketPlace.Web.Models;

namespace iMarketPlace.Web.Controllers
{
    public class CartController : BaseController
    {
        private readonly CartService _cartService;

        // GET: Cart
        public CartController()
        {
            _cartService = new CartService();
        }
        public ActionResult Add(int id)
        {
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            if (user == null)
            {
                return JavaScript("$('#login-modal').modal();");
            }
            var cart = new CartAddViewModel()
            {
                AdvertisementId = id,
                BuyerId = user.Id
            };
            _cartService.Add(cart);
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Summary()
        {
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            var cartOverview = new CartSummaryHolderViewModel();
            if (user != null)
                cartOverview = _cartService.GetUserCartItems(user.Id);
            var view = ConvertViewToString("_CartItem", cartOverview.OverViewItems);
            return Json(new { view, cartOverview.Total }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            return View();
        }
    }
}