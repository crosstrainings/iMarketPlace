using iMarketPlace.Web.Models;
using MarketPlace.Entities.Advertisements;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController()
        {
        }
        public ActionResult Create(Advertisement advertisement)
        {
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            advertisement.SellerId = user.Id;
            bool isAdded = _advertisementService.Add(advertisement);
            return RedirectToAction("Profile", "User");
        }
    }
}