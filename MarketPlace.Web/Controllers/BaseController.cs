using iMarketPlace.Services;
using System.IO;
using System.Web.Mvc;
namespace iMarketPlace.Web.Controllers
{
    public class BaseController : Controller
    {
        protected readonly AdvertisementService _advertisementService;
        protected readonly SellerService _sellerService;
        protected readonly BuyerService _buyerService;
        protected readonly LocationService _locationService;
        protected readonly UserService _userService;
        protected const string USER_SESSION = "User";

        public BaseController()
        {
            _advertisementService = new AdvertisementService();
            _sellerService = new SellerService();
            _buyerService = new BuyerService();
            _locationService = new LocationService();
            _userService = new UserService();
        }
        public void AddSession(string key, object value)
        {
            Session.Add(key, value);
        }

        public T GetSession<T>(string key)
        {
            return (T)Session[key];
        }
        public void RemoveSession()
        {
            Session.Abandon();
        }
        protected string ConvertViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }

    }
}