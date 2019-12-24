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
        public Advertisement GetByCode(string code)
        {
            return _advertisementRepository.Get(code);
        }
        public List<Advertisement> GetSellerAds(int userId)
        {
            return (List<Advertisement>)_advertisementRepository.GetSellerAds(userId);
        }
    }
}
