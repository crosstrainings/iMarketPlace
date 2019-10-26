using iMarketPlace.Web.Models;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    /*Permanent Storage:
     *- File System
     *- Database System
     *      - Technique / Concepts
     *      -   MYSQL (SQL) - MSSQL (SQL) - Oracle (SQL) - MongoDB (No SQL) - Hadoop
     *        - SQL (Structured Query Language)
     *          - Language To Communicate with Database
     *      - Providers / Vendors
     *      - Oracle - Microsoft - Oracle - //
     *      
     *- MSSQL 
     * - Tools
     *  - SQL Server 2016 - 2014
     *  - MSSQL (SQL Management Server ) (Browser)
     *
     * - How to Connect with SQL Server from Code 
     * - ADO.NET (Connection - Command - Read|Write) 
     * - ORM 
     *
     */



    public class ProductController : Controller
    {

        public ActionResult Create(Advertisement advertisement)
        {
            bool isAdded = AdvertisementManager.Add(advertisement);
            return RedirectToAction("Profile","User");
        }
    }
}