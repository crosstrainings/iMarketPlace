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
            return View();
        }


        public ActionResult Login(string userName, string password)
        {
            if (userName == "Admin" && password == "Admin")
            {
                IsLoggedIn = true;
                return RedirectToAction("Profile", "User");
            }
            return RedirectToAction("Index");
        }
    }
}