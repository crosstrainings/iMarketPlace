using iMarketPlace.Services;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class CountryController:AuthController
    {
        protected readonly LocationService _locationService;
        public CountryController()
        {
            _locationService = new LocationService();
        }
        // GET: Administration/Country
        public ActionResult Index()
        {
            var countries = _locationService.GetCountries();

            return PartialView("_Countries",countries);
        }
    }
}
