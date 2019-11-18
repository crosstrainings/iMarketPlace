namespace MarketPlace.Entities.Common
{
    public  class Address
    {
        public int Id { get; set; }

        public string StreetAddress { get; set; }
        public string HouseNumber { get; set; }
        public int? CityId { get; set; }
        public virtual City City { get; set; }

    }
}
