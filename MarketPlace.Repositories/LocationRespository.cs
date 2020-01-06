using System.Collections.Generic;
using System.Linq;
using MarketPlace.Entities.Common;
using System.Data.Entity;

namespace MarketPlace.Repositories
{
    public class LocationRespository
    {
        private MarketPlaceContext context;
        public LocationRespository()
        {
            context = new MarketPlaceContext();
        }
        public void AddCity(City city)
        {
            context.Cities.Add(city);
            context.SaveChanges();
        }
        public IList<City> GetCities()
        {
            return context.Cities.ToList();
        }

        public City GetCity(int id)
        {
            return (from c in context.Cities
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public void UpdateCity(City model)
        {
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
           
        }
        public void DeleteCity(int id)
        {
            var data = GetCity(id);
            context.Cities.Remove(data);
            context.SaveChanges();

        }

        public IList<City> GetCitiesByCountryId(int countryId)
        {
            return context.Cities
                          .Where(x => x.CountryId == countryId)
                          .ToList();
        }
        ////////////////////Country//////////////////////
        public void AddCountry(Country country)
        {
            context.Countries.Add(country);
            context.SaveChanges();
        }
        public IList<Country> GetCountries()
        {
            return context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return (from c in context.Countries
                    where c.Id == id
                    select c).FirstOrDefault();
        }

        public void UpdateCountry(Country model)
        {
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void DeleteCountry(int id)
        {
            var data = GetCountry(id);
            context.Countries.Remove(data);
            context.SaveChanges();

        }
    }
}