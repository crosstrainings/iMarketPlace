using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class ActionController : Controller
    {
        // GET: Administration/Action
        public ActionResult Index(string controller, string action)
        {
            return RedirectToAction(action,controller);
        }
    }
}