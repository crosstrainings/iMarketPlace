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

        public ActionResult Register(Person person)
        {
            if (person.IsSeller)
                _sellerService.Add(person);
            else
                _buyerService.Add(person);

            return RedirectToAction("Profile");
        }
    }
}