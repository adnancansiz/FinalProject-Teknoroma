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
        private readonly IExpenseService expenseService;
        private readonly IAppUserService appUserService;
        private readonly IEmployeePaymentService employeePaymentService;

        public ExpenseController(IExpenseService expenseService,IAppUserService appUserService,IEmployeePaymentService employeePaymentService)
        {
            this.expenseService = expenseService;
            this.appUserService = appUserService;
            this.employeePaymentService = employeePaymentService;
        }

        public ActionResult Index()
        {
            ViewBag.AppUser = appUserService.GetActive();
            ViewBag.EmployeePayment = employeePaymentService.GetActive();
            ViewBag.Expense = expenseService.GetActive();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense expense)
        {
            try
            {

                expenseService.Create(expense);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateEmployeePayment()
        {
            ViewBag.AppUser = appUserService.GetActive();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployeePayment(EmployeePayment employeePayment)
        {
            try
            {
                employeePaymentService.Create(employeePayment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(Guid id)
        {
            var exp = expenseService.GetById(id);
            return View(exp);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Expense expense)
        {
            try
            {
                expenseService.Update(expense);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditEmployeePayment(Guid id)
        {
            ViewBag.AppUser = appUserService.GetActive();
            var empPayment = employeePaymentService.GetById(id);
            return View(empPayment);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployeePayment(EmployeePayment employeePayment)
        {
            try
            {
                employeePaymentService.Update(employeePayment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult DeleteEmployeePayment(Guid id)
        {
            var deleteEmpPayment = employeePaymentService.GetById(id);
            employeePaymentService.Delete(deleteEmpPayment);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(Guid id)
        {
            var deleted = expenseService.GetById(id);
            expenseService.Delete(deleted);
            return RedirectToAction(nameof(Index));
        }

    }
}
