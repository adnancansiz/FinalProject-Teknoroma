using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class OrderDetail:BaseEntity
    {
        [Display(Name = "Tutar")]
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Adet")]
        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

    }
}
