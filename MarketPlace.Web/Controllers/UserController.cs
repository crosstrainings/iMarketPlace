using iMarketPlace.Web.Models;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login(string userName, string password)
        {
            return RedirectToAction("Profile");
        }
        // GET: User
        public ActionResult Profile()
        {
            ViewBag.Advertisements = AdvertisementManager.Get();
            return View();
        }

        public ActionResult Register(Person person)
        {
            return RedirectToAction("Profile");
        }
    }
}