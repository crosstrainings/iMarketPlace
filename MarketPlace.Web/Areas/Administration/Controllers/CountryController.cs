using iMarketPlace.Services;
using MarketPlace.ViewModels;
using System.Net;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class CountryController : AuthController
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

            return PartialView("_Countries", countries);
        }

        public ActionResult Add()
        {
            return PartialView("_Add");
        }
        [HttpPost]
        public ActionResult Add(CountryViewModel model)
        {

            var t = Request.IsAjaxRequest();

            _locationService.AddCountry(model);
            var countries = _locationService.GetCountries();

            return PartialView("_Countries", countries);
        }

        public ActionResult Update(int id)
        {
            var result = _locationService.GetCountry(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }
        [HttpPost]
        public ActionResult Update(CountryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _locationService.UpdateCountry(model);
                return RedirectToAction("Index");
            }
            return View("CountryViewModel");
        }
        public ActionResult Delete(int id)
        {
            _locationService.DeleteCountry(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var data = _locationService.GetCountry(id);
            return View(data);
        }
    }
}
