using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace iMarketPlace.Web.Models.Translators
{
    public static class TranslatorHelper
    {
        public static List<SelectListItem> ToSelectListItem(this List<CityViewModel> cities)
        {
            List<SelectListItem> vmData = cities.Select(item => new SelectListItem()
            {
                Text = item.Name,
                Value = item.Id.ToString()
            }).ToList();
            return vmData;
        }
    }
}
