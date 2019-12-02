using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Users;

namespace MarketPlace.Repositories
{
    public class UserRepository
    {
        private MarketPlaceContext context;
        public UserRepository()
        {
            context = new MarketPlaceContext();
        }

        private void Save()
        {
            context.SaveChanges();
        }
        public User GetUserByUserNameAndPassword(string userName, string password)
        {
            return context.Users.FirstOrDefault(x => x.UserName == userName ||
                                x.Email == userName &&
                                x.Password == password);
        }

    }
}