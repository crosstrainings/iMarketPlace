using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Entities.Orders
{
    public class CartDetail
    {
        [Key]
        [ForeignKey("Cart")]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
