using iMarketPlace.Web.Controllers;
using MarketPlace.ViewModels.Admin;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Administration/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllAdverts()
        {
            List<AdvertisementViewModel> allRecipes = new List<AdvertisementViewModel>();
            var advertisements = _advertisementService.Get();
            foreach (var ad in advertisements)
            {
                allRecipes.Add(new AdvertisementViewModel()
                {
                    Category = ad.Category.Name,
                    SubCategory = ad.Category.SubCategory.Name,
                    ImgUrl = ad.Images.First().Url,
                    Id = ad.Id,
                    Price = ad.Price.ToString(".00"),
                    Title = ad.Title,
                });
            }

            ViewBag.AllRecipes = allRecipes;

            return View();
        }
    }
}