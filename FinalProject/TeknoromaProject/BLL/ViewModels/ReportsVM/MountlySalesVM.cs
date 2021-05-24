using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ViewModels.ReportsVM
{
    public class MountlySalesVM
    {
        public DateTime OrderDate { get; set; }
        public string TCKN { get; set; }
        public string CustomerName { get; set; }
        public string EmployeUserName { get; set; }
        public decimal SalesTotal { get; set; }
        public Guid OrderId { get; set; }


    }
}
