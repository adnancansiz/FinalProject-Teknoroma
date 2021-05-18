using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class Expense:BaseEntity
    {
        public Expense()
        {
            PaymentDate = DateTime.Now;
        }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public string Explanation { get; set; }
        public Payments Payments { get; set; }
        public DateTime PaymentDate { get; set; }



    }
}
