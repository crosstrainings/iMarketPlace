using MarketPlace.Entities.Advertisements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ViewModels.Admin.Category
{
  public  class AddCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubCategoryName { get; set; }

    }
}
