using MarketPlace.ViewModels;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Login(string userName, string password)
        {
            //Sessions (Globally Accessable)
            //Server Data Storage
            //Key(Browser|Client) Value(Server) Pair
            if (_userService.UserExists(userName, password))
            {
                Session.Add("User", "User");
                return RedirectToAction("Profile");
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Profile()
        {
            var user = Session["User"];
            if (user != null)
            {
                ViewBag.Advertisements = _advertisementService.Get();
                return View();
            }
            return RedirectToAction("Index", "Home");
        }


        //State Management
        //Web - HTTP (By Nature Stateless)
        //State Management Ways
        //Sessions
        //Cookies
        //TempData
        public ActionResult Register(Person person)
        {
            var saved = false;
            if (person.IsSeller)
                saved = _sellerService.Add(person);
            else
                saved = _buyerService.Add(person);
            if (saved)
                Session.Add("User", "User");
            return RedirectToAction("Profile");
        }
    }
}