using iMarketPlace.Services;
using MarketPlace.API.Models;
using MarketPlace.Entities.Advertisements;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MarketPlace.API.Controllers
{
    public class AdvertisementController : ApiController
    {
        private readonly AdvertisementService _advertisementService;
        public AdvertisementController()
        {
            _advertisementService = new AdvertisementService();
        }

        [HttpGet]
        public List<AdvertisementModel> Get1()
        {
            var adverts =  _advertisementService.Get().Take(1);
            var data = new List<AdvertisementModel>();
            foreach (var item in adverts)
            {
                data.Add(new AdvertisementModel()
                {
                    Id = item.Id,
                    Price = item.Price,
                    Title= item.Title
                });
            }
            return data;
        }

        [HttpGet]
        public List<AdvertisementModel> Get2(double price)
        {
            var adverts =  _advertisementService.Get().Where(x=>x.Price==price).ToList();
            var data = new List<AdvertisementModel>();
            foreach (var item in adverts)
            {
                data.Add(new AdvertisementModel()
                {
                    Id = item.Id,
                    Price = item.Price,
                    Title= item.Title
                });
            }
            return data;
        }
    }
}
