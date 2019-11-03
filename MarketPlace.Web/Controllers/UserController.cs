using iMarketPlace.Web.Models;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    /*
     *  ADO.NET
     *  ORM (Object Relation Model)
     *      Translate Objects To Queries and Queries To Objects
     *
     *      EF  (Entity Framework)
     *      nHibernate
     *      Micro ORM 
     *
     *
     *  How to Add EF:
     *  Nuget Package Server | NPM 
     *  DLL
     *
     *
     *  EF (Entity Framework)
     *  Steps:
         *  Connection
         *  Scheme Structure
         *  Operations
         *
     *
     * Pros and Cons of ORM - Entity Framework
     *
     * Advantages:
     *  Easy To Install / Use
     *  Cleaner / Lesser Code
     *  No SQL Knowledge require
     *  In Programmer's Favor
     *  Productivity 
     *
     *
     *
     * Disadvantages
     *  Performance Low
     */



    /*DB Migrations
     *
     *enable-migrations - one time
     *add-migration NAME_OF_MIGRATION
     *update-database
     *
     */


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