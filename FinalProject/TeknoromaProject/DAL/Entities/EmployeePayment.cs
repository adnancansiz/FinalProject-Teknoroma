using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class EmployeePayment:BaseEntity
    {
        public EmployeePayment()
        {
            PaymentDate = DateTime.Now;
        }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public string Explanation { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PayingUser { get; set; }

        public AppUser AppUser { get; set; }
        public Guid AppUserId { get; set; }

    }
}
