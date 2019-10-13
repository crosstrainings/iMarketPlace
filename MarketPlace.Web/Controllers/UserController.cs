using iMarketPlace.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class UserController : Controller
    {
       public static Advertisement advertisement;
        // GET: User
        public ActionResult Profile()
        {

            ViewBag.Advertisement = UserController.advertisement;
            return View();
        }
        public ActionResult Create(Advertisement advertisement)
        {
            //Using Static
            UserController.advertisement = advertisement;

            //ViewBag | ViewData (1 Request)(Scope 1 Action Method)
            //ViewBag.title = advertisement.Title;
            //ViewBag.price = advertisement.Price;
            //ViewBag.category = advertisement.Category;
            //ViewBag.image = advertisement.Image;

            //ViewData["title"] = advertisement.Title;
            //ViewData["price"] = advertisement.Price;
            //ViewData["category"] = advertisement.Category;
            //ViewData["image"] = advertisement.Image;

            //Static (Globally Accessible By ClassName) | Session (Sesssion, Key Value Pair, Globally) | TempData (1 Request and redirection, Not Globally Available)


            return RedirectToAction("Profile");
        }
    }
}