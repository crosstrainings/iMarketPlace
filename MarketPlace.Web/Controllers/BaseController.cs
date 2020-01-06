using iMarketPlace.Services;
using System.IO;
using System.Web.Mvc;
using iMarketPlace.Web.Models;

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
        protected int UserId;

        public BaseController()
        {
            _advertisementService = new AdvertisementService();
            _sellerService = new SellerService();
            _buyerService = new BuyerService();
            _locationService = new LocationService();
            _userService = new UserService();
            UserId = GetSession<UserSessionInfo>(USER_SESSION)?.Id ?? 0;
        }
        public void AddSession(string key, object value)
        {
            Session.Add(key, value);
        }
        protected T GetSession<T>(string key)
        {
            if (Session != null)
                return (T) Session[key];
            return default(T);
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