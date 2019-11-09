namespace MarketPlace.Entities.Common
{
    public  class Address
    {
        public int Id { get; set; }

        public string StreetAddress { get; set; }
        public string HouseNumber { get; set; }
        public City City { get; set; }

    }
}
