using iMarketPlace.Web.Models;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Create(Advertisement advertisement)
        {
            bool isAdded = AdvertisementManager.Add(advertisement);
            return RedirectToAction("Profile","User");
        }
    }
}