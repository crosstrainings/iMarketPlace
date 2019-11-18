using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using MarketPlace.Repositories;
using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;

namespace iMarketPlace.Services
{
    public class BuyerService
    {
        private readonly BuyerRepository _buyerRepository;
        public BuyerService()
        {
            _buyerRepository = new BuyerRepository();
        }
        public bool Add(Person person)
        {
            try
            {
                Buyer buyer = new Buyer()
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
                _buyerRepository.Add(buyer);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
