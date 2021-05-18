using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ReportController : Controller
    {
        private readonly ISupplierExpenseService _supplierExpenseService;
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private readonly IAppUserService _appUserService;
        private readonly IOrderDetailService _orderDetailService;

        public ReportController(ISupplierExpenseService supplierExpenseService, IProductService productService, ISupplierService supplierService,IAppUserService appUserService,IOrderDetailService orderDetailService)
        {
            _supplierExpenseService = supplierExpenseService;
            _productService = productService;
            _supplierService = supplierService;
            _appUserService = appUserService;
            _orderDetailService = orderDetailService;
        }


        public IActionResult SupplierReport()
        {
            var allTimeReport = _supplierExpenseService.GetAllTimeReport();
            var mountlyReport = _supplierExpenseService.GetMountlyReport();

            ViewBag.AllTime = allTimeReport;
            ViewBag.Mountly = mountlyReport;

            return View();
        }

        public IActionResult ProductReport()
        {
            var products = _productService.GetByDefault(x => x.Status == DAL.Entities.Enum.Status.Deleted);
            return View(products);

        }

        public IActionResult ExpenseReport()
        {
            return View();
        }

        public IActionResult SalesTrackingReport()
        {
            var users = _appUserService.GetActive();
           
            return View(users);
        }
    }
}
