using iMarketPlace.Services;
using System.Web.Mvc;
namespace iMarketPlace.Web.Controllers
{
    public class BaseController:Controller
    {
        protected readonly AdvertisementService _advertisementService;
        public BaseController()
        {
            _advertisementService = new AdvertisementService();
        }
    }
}