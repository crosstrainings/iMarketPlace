using iMarketPlace.Web.Controllers;
using MarketPlace.Entities.Advertisements;
using MarketPlace.Repositories;
using MarketPlace.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class AdminController : BaseController
    {
        private MarketPlaceContext context;
        public AdminController()
        {
            context = new MarketPlaceContext();
        }
        // GET: Administration/Admin
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult AllAdverts()
        //{
        //    List<AdvertisementViewModel> allRecipes = new List<AdvertisementViewModel>();
        //    var advertisements = _advertisementService.Get();
        //    foreach (var ad in advertisements)
        //    {
        //        allRecipes.Add(new AdvertisementViewModel()
        //        {
        //            Category = ad.Category.Name,
        //            SubCategory = ad.Category.SubCategory.Name,
        //            ImgUrl = ad.Images.FirstOrDefault().Url,
        //            Id = ad.Id,
        //            Price = ad.Price.ToString(".00"),
        //            Title = ad.Title,
        //        });
        //    }

        //    ViewBag.AllRecipes = allRecipes;

        //    return View();
        //}

        public ActionResult ListOfAdver()
        {
            var advertisements = _advertisementService.Get();

            return PartialView("_AllAdverts", advertisements);
        }

        public ActionResult ListOfCategory()
        {
            var category= _advertisementService.GetAllCategories();

            return PartialView("_Categories",category);
        }
        public ActionResult ListOfSubCategory()
        {
            var subCategory = _advertisementService.GetAllSubCategories();

            return View(subCategory);
        }

        public ActionResult AdertisementDetails(int id)
        {

            var adverts = _advertisementService.Get(id);
            if (adverts == null)
            {
                return HttpNotFound();
            }
            return View(adverts);
        }

        public ActionResult DeleteAdvertisement( Advertisement model)
        {
           var data=  _advertisementService.Get(model.Id);
            _advertisementService.Delete(data);
           
            return RedirectToAction("ListOfAdver");
        }


        public ActionResult UpdateAdvertisement(Advertisement model)
        {
            var data = _advertisementService.Get(model.Id);
            _advertisementService.UpdateAdvertisement(data);

            return RedirectToAction("ListOfAdver");
        }
        public ActionResult Detail(int id)
        {
            var advertisement = _advertisementService.Get(id);
            return View(advertisement);
        }

    }
}