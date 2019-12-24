using Newtonsoft.Json;
namespace MarketPlace.Crawler.Daraz.Models
{
    public class DarazProductModel
    {
        [JsonProperty("itemId")]
        public string ItemCode { get; set; }
        [JsonProperty("itemImg")]
        public string ItemImg { get; set; }
        [JsonProperty("itemTitle")]
        public string ItemTitle { get; set; }
        [JsonProperty("itemPrice")]
        public double ItemPrice { get; set; }
    }
}
