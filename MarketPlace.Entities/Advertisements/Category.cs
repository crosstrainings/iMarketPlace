using System;

namespace MarketPlace.Entities.Advertisements
{
    public class Category
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}