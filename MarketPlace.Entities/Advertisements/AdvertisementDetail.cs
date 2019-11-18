using MarketPlace.Entities.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Advertisements
{
    public class AdvertisementDetail
    {
        [Key]
        [ForeignKey("Advertisement")]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ExpiredOn { get; set; }
        public TimeSpan Duration { get; set; }
        public virtual List<Order> Orders { get; set; }
        public int Rank { get; set; }
        public virtual Advertisement Advertisement { get; set; }
    }
}
