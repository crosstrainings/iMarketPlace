using MarketPlace.Entities.Common;
using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Services.Translators
{
    public static class EntityToVMTranslator
    {

        public static List<CityViewModel> Translate(this List<City> cities)
        {
            List<CityViewModel> vmData = cities.Select(item => new CityViewModel()
            {
                Code = item.Code,
                CountryId = item.CountryId,
                Id = item.Id,
                Name = item.Name
            }).ToList();
            return vmData;
        }
        

    }
}
