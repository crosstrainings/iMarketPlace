using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Common;
using MarketPlace.Entities.Users;
using MarketPlace.Repositories;
using MarketPlace.ViewModels;
using System;
using System.Collections.Generic;

namespace iMarketPlace.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User UserExists(string userName,string password)
        {
            var user = _userRepository.GetUserByUserNameAndPassword(userName, password);
            return user;
        }
    }
}
