using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Entities.Advertisements;

namespace MarketPlace.Repositories.SubCategories
{
   public class SubCategoryRepository
    {

        private MarketPlaceContext context;
        public SubCategoryRepository()
        {
            context = new MarketPlaceContext();
        }
        public void AddCategory(SubCategory subCategory)
        {
            context.SubCategories.Add(subCategory);
            context.SaveChanges();
        }
     

        public SubCategory GetById(int id)
        {
            return (from c in context.SubCategories.OrderByDescending(x => x.Id)
                    where c.Id == id
                    select c).FirstOrDefault();

        }

        public void Update(SubCategory subCategory)
        {
            context.Entry(subCategory).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void Delete(int id)
        {
            var data = GetById(id);
            context.SubCategories.Remove(data);
            context.SaveChanges();

        }
        public List<SubCategory> GetAllSubCategories()
        {
            return context.SubCategories.OrderByDescending(x => x.Id).ToList();
        }
    }
}
