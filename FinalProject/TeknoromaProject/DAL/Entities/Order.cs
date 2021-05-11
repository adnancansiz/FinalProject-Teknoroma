using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderDate = DateTime.Now;
        }


        [Display(Name = "Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }

        public  virtual List<OrderDetail> OrderDetails { get; set; }



    }
}
