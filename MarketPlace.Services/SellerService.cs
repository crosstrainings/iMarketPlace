using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using MarketPlace.Repositories;
using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;

namespace iMarketPlace.Services
{
    public class SellerService
    {
        private readonly SellerRepository _sellerRepository;
        public SellerService()
        {
            _sellerRepository = new SellerRepository();
        }
        public bool Add(Person person)
        {
            try
            {
                Seller seller = new Seller()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Email = person.Email,
                    Password = person.Password,
                    Address = new Address()
                    {
                        CityId = person.CityId
                    }

                };
                _sellerRepository.Add(seller);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
