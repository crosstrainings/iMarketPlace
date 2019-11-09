using System.Collections.Generic;

namespace MarketPlace.Entities.Common
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Code { get; set; }
        public Country Country { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
