using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using MarketPlace.Repositories;
using MarketPlace.Services.Translators;
using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace iMarketPlace.Services
{
    public class LocationService
    {
        private readonly LocationRespository _locationRespository;
        public LocationService()
        {
            _locationRespository = new LocationRespository();
        }
        public List<CityViewModel> GetCities()
        {
            List<CityViewModel> data = _locationRespository.GetCities()
                                                           .ToList()
                                                           .Translate();
            return data;
        }
        public List<CityViewModel> GetCitiesByCountryId(int countryId)
        {
            List<CityViewModel> data = _locationRespository.GetCitiesByCountryId(countryId)
                                                           .ToList()
                                                           .Translate();
            return data;
        }
        public IList<CountryViewModel> GetCountries()
        {
            return _locationRespository.GetCountries().ToList().Translate();
        }
        public void AddCity(CityViewModel model)
        {
            City city = new City()
            {
                Name = model.Name,
                Code = model.Code,
            };
            _locationRespository.AddCity(city);
        }
        public CityViewModel GetCity(int id)
        {
            var city = _locationRespository.GetCity(id);
            var cityVM = new CityViewModel()
            {
                Id = city.Id,
                Name = city.Name,
                Code = city.Code
            };
            return cityVM;
        }
        public void UpdateCity(City model)
        {
            City city = new City()
            {
                Name = model.Name,
                Code = model.Code,
                Id = model.Id
            };
            _locationRespository.UpdateCity(city);

        }
        public void DeleteCity(int id)
        {
            _locationRespository.DeleteCity(id);

        }
        public CountryViewModel GetCountry(int id)
        {
            var country = _locationRespository.GetCountry(id);
            var countryVM = new CountryViewModel()
            {
                Id = country.Id,
                Name = country.Name,
                Code = country.Code
            };
            return countryVM;
        }
        public void UpdateCountry(CountryViewModel model)
        {
            Country country = new Country()
            {
                Name = model.Name,
                Code = model.Code,

            };
            _locationRespository.UpdateCountry(country);

        }
        public void DeleteCountry(int id)
        {
            _locationRespository.DeleteCountry(id);

        }
        public void AddCountry(CountryViewModel model)
        {
            Country country = new Country()
            {
                Name = model.Name,
                Code = model.Code,
            };
            _locationRespository.AddCountry(country);
        }
    }
}
