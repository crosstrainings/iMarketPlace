using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
        }
        // GET: Home
        public ActionResult Index()
        {
            var user = Session["User"];
            var isLoggedIn = false;
            if (user != null)
            {
                isLoggedIn = user.ToString() == "User" ? true : false;
            }

            ViewBag.IsLoggedIn = isLoggedIn;
            ViewBag.Advertisements = _advertisementService.Get();
            return View();
        }
    }
}