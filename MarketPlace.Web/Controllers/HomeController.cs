using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class HomeController : BaseController
    {
        public static bool IsLoggedIn = false;
        public HomeController()
        {
        }
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.IsLoggedIn = IsLoggedIn;
            ViewBag.Advertisements = _advertisementService.Get();
            return View();
        }
    }
}