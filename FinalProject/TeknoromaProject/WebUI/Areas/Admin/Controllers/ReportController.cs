using BLL.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    public class ReportController : Controller
    {
        private readonly ISupplierService _supplierService;

        public ReportController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

       
        public IActionResult SupplierReport()
        {
            
            return View();
        }

        public IActionResult ProductReport()
        {
            return View();
        }

        public IActionResult ExpenseReport()
        {
            return View();
        }

        public IActionResult SalesTrackingReport()
        {
            return View();
        }
    }
}
