using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class SupplierExpense:BaseEntity
    {
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public short Quantity { get; set; }

        public decimal TotalPrice { get => Price * Quantity; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

    }
}
