using MarketPlace.Entities.Common;
namespace MarketPlace.Entities.Users
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int? ProfileImageId { get; set; }
        public virtual Image ProfileImage { get; set; }
        public int? CoverImageId { get; set; }
        public virtual Image CoverImage { get; set; }
        public int Rank { get; set; }
        public int? BadgeId { get; set; }
        public virtual Badge Badge { get; set; }
    }
}
