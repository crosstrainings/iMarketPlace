using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iMarketPlace.Web.Models
{
    public class Advertisement
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public int Category { get; set; }
        public string Image { get; set; }
    }
}