﻿using MarketPlace.Entities.Advertisements;
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
            try
            {
                advertisement.Badge = new MarketPlace.Entities.Common.Badge()
                {
                    Code = "New",
                    Description = string.Empty,
                    Icon = null,
                    Title = "New"
                };
                _advertisementRepository.Add(advertisement);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Advertisement> Get()
        {
            return (List<Advertisement>)_advertisementRepository.Get();
        }
    }
}