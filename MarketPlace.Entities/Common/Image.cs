using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Common
{
    public class Image
    {
        public string Url { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
    }
}
