using iMarketPlace.Services;
using System.Web.Mvc;
namespace iMarketPlace.Web.Controllers
{
    public class BaseController:Controller
    {
        protected readonly AdvertisementService _advertisementService;
        protected readonly SellerService _sellerService;
        protected readonly BuyerService _buyerService;

        public BaseController()
        {
            _advertisementService = new AdvertisementService();
            _sellerService = new SellerService();
            _buyerService = new BuyerService();
        }
    }
}