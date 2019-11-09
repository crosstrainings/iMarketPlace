using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class HomeController : Controller
    {
        public static bool IsLoggedIn = false;
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.IsLoggedIn = IsLoggedIn;
          //  ViewBag.Advertisements = AdvertisementManager.Get();
            return View();
        }
    }
}