using System;

namespace MarketPlace.Entities.Advertisements
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}