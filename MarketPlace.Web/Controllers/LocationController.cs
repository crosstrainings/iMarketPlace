using iMarketPlace.Web.Models;
using iMarketPlace.Web.Models.Translators;
using MarketPlace.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace iMarketPlace.Web.Controllers
{
    public class LocationController : BaseController
    {
        [HttpGet]
        public ActionResult GetCitiesByCountryId(int? countryId)
        {
            List<CityViewModel> cities = new List<CityViewModel>();
            if (countryId != null)
                cities = _locationService.GetCitiesByCountryId((int)countryId);
            else
                cities = _locationService.GetCities();


            DropDownModel model = new DropDownModel()
            {
                Name = "city-list",
                List = cities.ToSelectListItem()
            };


            return PartialView("~/Views/Shared/_DropDownListView.cshtml", model);
            //return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}