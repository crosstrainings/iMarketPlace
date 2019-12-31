using MarketPlace.Entities.Advertisements;
using MarketPlace.Repositories;
using System;
using System.Collections.Generic;

namespace iMarketPlace.Services
{
    public class AdvertisementService
    {
        private readonly AdvertisementRepository _advertisementRepository;
        public AdvertisementService()
        {
            _advertisementRepository = new AdvertisementRepository();
        }

        public bool Add(Advertisement advertisement)
        {
            _advertisementRepository.Add(advertisement);
            return true;
        }

        public List<Advertisement> Get()
        {
            return (List<Advertisement>)_advertisementRepository.Get();
        }

        public Advertisement Get(int id)
        {
           var data= _advertisementRepository.Get(id);
            return data;
        }

        public void UpdateAdvertisement(Advertisement advertisement)
        {
            _advertisementRepository.UpdateAdvertisement(advertisement);
            
        }
        public Advertisement GetByCode(string code)
        {
            return _advertisementRepository.Get(code);
        }
        public List<Advertisement> GetSellerAds(int userId)
        {
            return (List<Advertisement>)_advertisementRepository.GetSellerAds(userId);
        }

        public List<Category> GetAllCategories()
        {
          var categories=  _advertisementRepository.GetAllCategories();
            return categories;
        }
        public List<SubCategory> GetAllSubCategories()
        {
            var subcategories = _advertisementRepository.GetAllSubCategories();
            return subcategories;
        }


        public void Delete(Advertisement adver)
        {
          _advertisementRepository.Delete(adver);
           
        }
    }
}
