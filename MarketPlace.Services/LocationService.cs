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

    }
}
