using MarketPlace.Entities.Advertisements;
using MarketPlace.Repositories.SubCategories;
using MarketPlace.ViewModels.Admin.SubCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services
{
   public class SubCategoryService
    {
        private SubCategoryRepository _subCategoryRepository;
        public SubCategoryService()
        {
            _subCategoryRepository = new SubCategoryRepository();
        }

        public void AddSubCategory(SubCategoryViewModel model)
        {
            var subCategory = new SubCategory()
            {
                Name = model.Name,
                Id = model.Id,
              
            };
            _subCategoryRepository.AddCategory(subCategory);
        }
        public List<SubCategoryViewModel> GetAll()
        {
            var subCategoryVML = new List<SubCategoryViewModel>();
            var subCategoryM = _subCategoryRepository.GetAllSubCategories();
            if (subCategoryM != null && subCategoryM.Count > 0)
            {
                foreach (var subCategory in subCategoryM)
                {
                    var categoryVM = new SubCategoryViewModel();
                    categoryVM.Id = subCategory.Id;
                    categoryVM.Name = subCategory.Name;
                    subCategoryVML.Add(categoryVM);
                }
            }
            return subCategoryVML;

        }

        public SubCategoryViewModel GetById(int id)
        {
            var subCategoryVM = new SubCategoryViewModel();
            var categoryM = _subCategoryRepository.GetById(id);

            subCategoryVM.Name = categoryM.Name;
            subCategoryVM.Id = categoryM.Id;
            return subCategoryVM;

        }

        public void Update(SubCategoryViewModel model)
        {
            var subCategory = new SubCategory()
            {
                Name = model.Name,
                Id = model.Id,
            };

            _subCategoryRepository.Update(subCategory);
        }
        public void Delete(int id)
        {
            _subCategoryRepository.Delete(id);
        }

    }
}
