using System.Collections.Generic;
namespace MarketPlace.Entities.Common
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Code { get; set; }
        public List<City> Cities { get; set; }
    }
}
