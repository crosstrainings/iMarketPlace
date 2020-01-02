using iMarketPlace.Services;
using MarketPlace.Entities.Advertisements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iMarketPlace.Web.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly AdvertisementService _advertisementService;
        public DefaultController()
        {
            _advertisementService = new AdvertisementService();
        }
        public List<Advertisement> GetAll()
        {
            return _advertisementService.Get();
        }

    }
}
