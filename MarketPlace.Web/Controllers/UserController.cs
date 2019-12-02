using MarketPlace.ViewModels;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Login(string userName, string password)
        {
            return RedirectToAction("Profile");
        }

        public ActionResult Profile()
        {
            ViewBag.Advertisements = _advertisementService.Get();
            return View();
        }

        //TDD (Test Driven Developement)
        //Unit Testing
        //Microsoft/Visual Studio Test Framework
        //nUnit Test
        //xUnit Test
        public ActionResult Register(Person person)
        {
            var saved = false;
            var avc = string.Empty;
            if (person.IsSeller)
            {
                saved = _sellerService.Add(person);
            }
            else
                saved = _buyerService.Add(person);

            if (saved)
            {
                return RedirectToAction("Profile");
            }
            else
            {
                return null;
            }
        }
    }
}