using iMarketPlace.Web.Models;
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
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            UserSessionInfo userInfo = null;
            if (user != null)
            {
                userInfo = user;
            }

            ViewBag.UserInfo = userInfo;
            ViewBag.Advertisements = _advertisementService.Get();
            return View();
        }
    }
}