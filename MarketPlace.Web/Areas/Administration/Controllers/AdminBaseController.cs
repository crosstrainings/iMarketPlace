using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class AdminBaseController : Controller
    {
        // GET: Administration/AdminBase
        public ActionResult Index()
        {
            return View();
        }
    }
}