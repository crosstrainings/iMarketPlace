using MarketPlace.Entities.Common;
namespace MarketPlace.Entities.Users
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public Image ProfileImage { get; set; }
        public Image CoverImage { get; set; }
        public int Rank { get; set; }
        public Badge Badge { get; set; }
    }
}
