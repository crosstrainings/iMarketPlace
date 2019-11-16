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
            bool isAdded = _advertisementService.Add(advertisement);
            return RedirectToAction("Profile", "User");
        }
    }
}