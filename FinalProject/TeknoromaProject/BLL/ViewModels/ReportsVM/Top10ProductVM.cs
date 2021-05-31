using DAL.Entities;
using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ViewModels.ReportsVM
{
    public class Top10ProductVM
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int TotalSell { get; set; }

        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
