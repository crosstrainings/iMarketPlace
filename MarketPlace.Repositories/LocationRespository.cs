using System.Collections.Generic;
using System.Linq;
using MarketPlace.Entities.Common;

namespace MarketPlace.Repositories
{
    public class LocationRespository
    {
        private MarketPlaceContext context;
        public LocationRespository()
        {
            context = new MarketPlaceContext();
        }
 
        public IList<City> GetCities()
        {
            return context.Cities.ToList();
        }
        public IList<City> GetCitiesByCountryId(int countryId)
        {
            return context.Cities
                          .Where(x=>x.CountryId==countryId)
                          .ToList();
        }

        public IList<Country> GetCountries()
        {
            return context.Countries.ToList();
        }
    }
}