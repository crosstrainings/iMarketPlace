using MarketPlace.Entities.Advertisements;
using MarketPlace.Entities.Users;
namespace MarketPlace.Entities.Orders
{
    public class Cart
    {
        public int Id { get; set; }
        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public int BuyerId { get; set; }
        public virtual Buyer Buyer { get; set; }
        public int CartDetailId { get; set; }
        public virtual CartDetail CartDetail { get; set; }
    }
}
