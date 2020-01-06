using iMarketPlace.Web.Controllers;
using MarketPlace.Entities.Advertisements;
using MarketPlace.ViewModels.Admin.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class CategoryController :BaseController
    {
        // GET: Administration/Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfCategory()
        {
            var category = _categoryService.GetAll();

            return PartialView("_Categories", category);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return PartialView("_AddCategory");
        }
        [HttpPost]
        public ActionResult AddCategory(AddCategoryViewModel category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction("ListOfCategory");
        }

        public ActionResult Details(int id)
        {
            var data = _categoryService.GetById(id);
            return View(data);
        }
        public ActionResult Update(int id, AddCategoryViewModel model )
        {
            var data = _categoryService.GetById(id);
                   _categoryService.Update(data);
            return RedirectToAction("ListOfCategory");
        }

    }
}