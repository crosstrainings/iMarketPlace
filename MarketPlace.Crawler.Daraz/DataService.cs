using HtmlAgilityPack;
using iMarketPlace.Services;
using MarketPlace.Crawler.Daraz.Models;
using MarketPlace.Entities.Advertisements;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace MarketPlace.Crawler.Daraz
{
    public partial class DataService : ServiceBase
    {
        private const string X_PATH = "//script[@class='J_dynamic_data']";
        private const string GLOBAL_COLLECTION_URL = "https://www.daraz.pk/wow/i/pk/campaigns/global-collection-main?spm=a2a0e.home.menu.2.35e34937kNJABX&hybrid=1&scm=1003.4.icms-zebra-5029921-2824053.OTHER_5996932240_5309936";
        private readonly AdvertisementService _advertisementService;
        public DataService()
        {
            InitializeComponent();
            _advertisementService = new AdvertisementService();
        }

        protected override void OnStart(string[] args)
        {
            LoadData();
        }
        public void LoadData()
        {
            var url = GLOBAL_COLLECTION_URL;
            HtmlWeb website = new HtmlWeb();
            HtmlDocument htmlDocument = website.Load(url);
            var nodesCollection = htmlDocument.DocumentNode.SelectNodes(X_PATH);
            var nodesArray = nodesCollection.ToArray();
            int saved = 0;
            int total = 0;
            int exists = 0;
            int failed = 0;
            int skiped = 0;
            foreach (HtmlNode item in nodesArray)
            {
                try
                {
                    var dataString = item.InnerText.Trim();
                    var products = JsonConvert.DeserializeObject<List<DarazProductModel>>(dataString);
                    total = products.Count;
                    foreach (var product in products)
                    {
                        if (string.IsNullOrEmpty(product.ItemCode))
                        {
                            skiped++;
                            continue;
                        }
                        var prod = _advertisementService.GetByCode(product.ItemCode);
                        if (prod != null)
                        {
                            exists++;
                            continue;
                        }
                        var advert = new Advertisement()
                        {
                            Title = product.ItemTitle,
                            Price = product.ItemPrice,
                            Images = new List<Entities.Common.Image>()
                            {
                                new Entities.Common.Image()
                                {
                                    Url=product.ItemImg
                                }
                            },
                            Detail = new AdvertisementDetail()
                            {
                                ItemCode = product.ItemCode,
                                CreatedOn = DateTime.Now,
                                ExpiredOn= DateTime.Now
                            },
                            CategoryId = 7

                        };
                        _advertisementService.Add(advert);
                        saved++;
                        Console.WriteLine("Success...");
                    }
                }
                catch(Exception ex)
                {
                    failed++;
                    Console.WriteLine("failed...");
                }
            }
            Console.WriteLine($"\n" +
                              $"Process Summary\n" +
                              $"Total   : {total}\n" +
                              $"Added   : {saved}\n" +
                              $"Failed  : {failed}\n" +
                              $"Skipped : {skiped}\n"+
                              $"Exists  : {exists}\n");
            Console.ReadKey();

        }
        protected override void OnStop()
        {
        }
    }
}
