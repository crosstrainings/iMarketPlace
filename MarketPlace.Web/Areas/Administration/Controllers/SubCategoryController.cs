using iMarketPlace.Web.Controllers;
using MarketPlace.ViewModels.Admin.SubCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMarketPlace.Web.Areas.Administration.Controllers
{
    public class SubCategoryController : BaseController
    {
        // GET: Administration/SubCategory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfSubCategory()
        {
            var subCategory = _subCategoryService.GetAll();

            return View(subCategory);
        }
        public ActionResult Add()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Add(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _subCategoryService.AddSubCategory(model);

            }

            return RedirectToAction("ListOfSubCategory");
        }

        public ActionResult Delete(int id)
        {
             _subCategoryService.Delete(id);
            return RedirectToAction("ListOfSubCategory");
        }

        public ActionResult Details(int id)
        {
           var data= _subCategoryService.GetById(id);
            if (data != null)
            {
               return HttpNotFound();
            }
            return View(data);
        }

        public ActionResult Update(int id, SubCategoryViewModel model)
        {
            var data = _subCategoryService.GetById(id);
            if (data != null)
            {
                return HttpNotFound();
            }
            _subCategoryService.Update(model);
            return RedirectToAction("ListOfSubCategory");
        }
    }
}