using MarketPlace.Entities.Advertisements;
using MarketPlace.Repositories;
using MarketPlace.ViewModels.Admin.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services
{
   public class CategoryService
    {
        private CategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public void AddCategory(AddCategoryViewModel model)
        {
            var category = new Category()
            {
                Name = model.Name,
                Id = model.Id,
                SubCategory = new SubCategory()
                {
                    Name = model.Name
                }
            };
            _categoryRepository.AddCategory(category);
        }
        public List<AddCategoryViewModel> GetAll()
        {
            var categoryVML = new List<AddCategoryViewModel>();
            var categoryM = _categoryRepository.GetAllCategories();
            if (categoryM != null && categoryM.Count > 0)
            {
                foreach (var category in categoryM)
                {
                    var categoryVM = new AddCategoryViewModel();
                    categoryVM.Id = category.Id;
                    categoryVM.Name = category.Name;
                    categoryVM.SubCategoryName = category.SubCategory.Name;

                    categoryVML.Add(categoryVM);
                }
            }
            return categoryVML;

        }

        public AddCategoryViewModel GetById(int id)
        {
            var categoryVM = new AddCategoryViewModel();
            var categoryM = _categoryRepository.GetById(id);

            categoryVM.Name = categoryM.Name;
            categoryVM.Id = categoryM.Id;
            categoryVM.SubCategoryName = categoryM.Name;
            return categoryVM;

        }

        public void Update(AddCategoryViewModel model)
        {
            var category = new Category()
            {
               Name = model.Name,
                Id= model.Id,
                SubCategory=new SubCategory() { Name=model.Name},
            };

            _categoryRepository.Update(category);
        }
        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    
       
    }
}
