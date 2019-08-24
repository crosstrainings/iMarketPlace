using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Entities.Payments
{
    public class PaymentMethod
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
