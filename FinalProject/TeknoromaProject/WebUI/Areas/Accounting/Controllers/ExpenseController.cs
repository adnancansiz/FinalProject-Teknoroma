using BLL.ApiData;
using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Accounting.Controllers
{
    [Area("Accounting")]
    [Authorize(Roles = "Accounting")]
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _expenseService;
        private readonly IAppUserService _appUserService;
        private readonly IEmployeePaymentService _employeePaymentService;

        public ExpenseController(IExpenseService expenseService,IAppUserService appUserService,IEmployeePaymentService employeePaymentService)
        {
            _expenseService = expenseService;
            _appUserService = appUserService;
            _employeePaymentService = employeePaymentService;
        }

        public ActionResult Index()
        {
            ViewBag.AppUser = _appUserService.GetActive();
            ViewBag.EmployeePayment = _employeePaymentService.GetActive();
            ViewBag.Expense = _expenseService.GetActive();
            return View();
        }
        
        public ActionResult SelectMount()
        {
            return View();
        }
        
        public ActionResult Sales(DateTime time)
        {
            var salesList = _expenseService.MountlySales(time);
            return View(salesList);
        }
        

        public ActionResult Create()
        {
            EuroDolarXml doviz = new EuroDolarXml();
            ViewBag.Dolar = doviz.Dolar;
            ViewBag.Euro = doviz.Euro;
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense expense)
        {
            try
            {

                _expenseService.Create(expense);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult CreateEmployeePayment()
        {
            EuroDolarXml doviz = new EuroDolarXml();
            ViewBag.Dolar = doviz.Dolar;
            ViewBag.Euro = doviz.Euro;
            ViewBag.AppUser = _appUserService.GetActive();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployeePayment(EmployeePayment employeePayment)
        {
            try
            {
                _employeePaymentService.Create(employeePayment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(Guid id)
        {
            var exp = _expenseService.GetById(id);
            return View(exp);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Expense expense)
        {
            try
            {
                _expenseService.Update(expense);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditEmployeePayment(Guid id)
        {
            ViewBag.AppUser = _appUserService.GetActive();
            var empPayment = _employeePaymentService.GetById(id);
            return View(empPayment);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployeePayment(EmployeePayment employeePayment)
        {
            try
            {
                _employeePaymentService.Update(employeePayment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult DeleteEmployeePayment(Guid id)
        {
            var deleteEmpPayment = _employeePaymentService.GetById(id);
            _employeePaymentService.Delete(deleteEmpPayment);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(Guid id)
        {
            var deleted = _expenseService.GetById(id);
            _expenseService.Delete(deleted);
            return RedirectToAction(nameof(Index));
        }

    }
}
