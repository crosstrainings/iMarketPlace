﻿//ERROR: One or more validation errors were detected during model generation:
//iMarketPlace.Web.Models.Advertisement: : EntityType 'Advertisement' has no key defined.Define the key for this EntityType.
//Advertisements: EntityType: EntitySet 'Advertisements' is based on type 'Advertisement' that has no keys defined.



//SOLUTION:
// - Convention 
// - Data Annotation 
// - Fluent API 

using System.ComponentModel.DataAnnotations;

namespace iMarketPlace.Web.Models
{
    public class Advertisement
    {
        //Convention
        public int Id { get; set; }

        //Data Annotations
        ////[Key]
        //public int RegistrationNumber { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string Title { get; set; }
        public string Price { get; set; }
        public virtual Category Category { get; set; }
        public string Image { get; set; }
    }
}