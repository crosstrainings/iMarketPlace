using iMarketPlace.Web.Models;
using MarketPlace.Entities.Advertisements;
using System.Linq;
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

        public ActionResult Load(int skip = 0, int take = 10)
        {
            var advertisements = _advertisementService.Get().Skip(skip).Take(take).ToList();
            var view = ConvertViewToString("_AdvertisementListView", advertisements);
            return Json(new { view, advertisements.Count }, JsonRequestBehavior.AllowGet);
        }
    }
}