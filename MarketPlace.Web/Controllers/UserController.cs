using iMarketPlace.Web.Models;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Profile()
        {
            ViewBag.Advertisements = AdvertisementManager.Get();
            return View();
        }
    }
}