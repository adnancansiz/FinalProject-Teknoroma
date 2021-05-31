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
        private readonly IExpenseService _expenseService;
        private readonly IEmployeePaymentService _employeePaymentService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public ReportController(ISupplierExpenseService supplierExpenseService, IProductService productService, ISupplierService supplierService,IAppUserService appUserService,IOrderDetailService orderDetailService,IExpenseService expenseService,IEmployeePaymentService employeePaymentService,ICategoryService categoryService,ISubCategoryService subCategoryService)
        {
            _supplierExpenseService = supplierExpenseService;
            _productService = productService;
            _supplierService = supplierService;
            _appUserService = appUserService;
            _orderDetailService = orderDetailService;
            _expenseService = expenseService;
            _employeePaymentService = employeePaymentService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
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
            try
            {
                var products = _productService.GetByDefault(x => x.Status == DAL.Entities.Enum.Status.Deleted);
                ViewBag.Product = products;

                var top10 = _productService.GetTop10();


                return View(top10);
            }
            catch (Exception)
            {
                TempData["Error"] = "Upss.. Bir hata meydana  geldi.";
                return View();
            }

        }

        public IActionResult ProductBuyers(Guid productId)
        {
            try
            {
                var top10 = _productService.GetTop10().Where(x => x.ProductId == productId);
                if (top10.Count() > 0)
                {
                    List<Customer> customers = new List<Customer>();
                    foreach (var item in top10)
                    {
                        foreach (var customer in item.Customers)
                        {
                            customers.Add(customer);
                        }
                    }

                    return View(customers);
                }

                TempData["Error"] = "Ürün Id'ye ulaşılamıyor lütfen tekrar deneyin";
                return View();
            }
            catch (Exception)
            {

                TempData["Error"] = "Upss.. Bir hata meydana  geldi.";
                return View();
            }

        }

        public IActionResult CategoryReport()
        {
            ViewBag.SubCategory = _subCategoryService.GetActive();
            return View(_categoryService.GetActive());
        }

        public IActionResult ProductList(Guid id)
        {
            var productList = _productService.GetByDefault(x => x.SubCategoryId == id);
            ViewBag.Suppliers = _supplierService.GetActive();
            ViewBag.subCategories = _subCategoryService.GetActive();

            return View(productList);
        }

        public IActionResult ExpenseReport()
        {
            ViewBag.Expense = _expenseService.GetActive();
            ViewBag.EmployeePayment = _employeePaymentService.GetActive();
            ViewBag.AppUser = _appUserService.GetActive();

            return View();
        }

        public IActionResult SalesTrackingReport()
        {
            var users = _appUserService.GetActive();
           
            return View(users);
        }

    }
}
