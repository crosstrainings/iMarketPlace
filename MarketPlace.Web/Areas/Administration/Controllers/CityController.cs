using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class CityController : AuthController
    {
        // GET: Administration/City
        public ActionResult Index()
        {
            return PartialView("_Cities");
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}