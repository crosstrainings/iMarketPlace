using iMarketPlace.Web.Models;
using MarketPlace.ViewModels;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : BaseController
    {

        //GhostDoc 2019     
        //Help View for Window 10 [https://www.microsoft.com/en-pk/download/details.aspx?id=21138]
        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public ActionResult Login(string userName, string password)
        {

            var user = _userService.UserExists(userName, password);
            if (user != null)
            {
                var userSessioninfo = new UserSessionInfo()
                {
                    Id = user.Id,
                    Name = user.FirstName + " " + user.LastName,
                    //Avatar = user.ProfileImage.Url
                };
                AddSession(USER_SESSION, userSessioninfo);
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            return Json("Failed", JsonRequestBehavior.AllowGet);
        }




        //SignalR [Installation]
        //Nuget Package
        //Add Depedency(JS [jQuery])

        //Configuration
        //StartUp (OWIN)
        //Hub (C# Class Inherit Hub)
            //Methods
        //Add Client Dependencies
        //Connection Establishment
        public ActionResult Profile()
        {
            var user = GetSession<UserSessionInfo>(USER_SESSION);
            if (user != null)
            {
                ViewBag.Advertisements = _advertisementService.GetSellerAds(user.Id);
                ViewBag.UserName = user.Name;
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register(Person person)
        {
            var saved = false;
            if (person.IsSeller)
                saved = _sellerService.Add(person);
            else
                saved = _buyerService.Add(person);
            if (saved)
            {
                var user = _userService.UserExists(person.Email, person.Password);
                if (user != null)
                {
                    var userSessioninfo = new UserSessionInfo()
                    {
                        Id = user.Id,
                        Name = user.FirstName + " " + user.LastName,
                      //  Avatar = user.ProfileImage.Url
                    };
                    AddSession(USER_SESSION, userSessioninfo);
                }
            }
            return RedirectToAction("Profile");
        }

        public ActionResult Logout()
        {
            RemoveSession();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Settings()
        {

            return View("Settings");
        }


    }
}