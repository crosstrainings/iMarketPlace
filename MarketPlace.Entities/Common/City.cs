using System.Collections.Generic;

namespace MarketPlace.Entities.Common
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Code { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
