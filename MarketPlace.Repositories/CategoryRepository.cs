using MarketPlace.Entities.Advertisements;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Repositories
{
    public class CategoryRepository
    {
        private MarketPlaceContext context;
        public CategoryRepository()
        {
            context = new MarketPlaceContext();
        }
        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }
        public List<Category> GetAllCategories()
        {
            return context.Categories.OrderByDescending(x => x.Id).ToList();
        }

        public Category GetById(int id)
        {
            return (from c in context.Categories.OrderByDescending(x=>x.Id)
                    where c.Id == id
                    select c).FirstOrDefault();
                   
        }

        public void Update(Category category)
        {
          context.Entry(category).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void Delete(int id)
        {

            var data = GetById(id);
            context.Categories.Remove(data);
            context.SaveChanges();

        }
        public List<SubCategory> GetAllSubCategories()
        {
            return context.SubCategories.OrderByDescending(x => x.Id).ToList();
        }
    }
}
