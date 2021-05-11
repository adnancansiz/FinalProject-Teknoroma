using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.TechnicalService.Controllers
{
    [Area("TechnicalService")]
    [Authorize(Roles = "TechnicalService")]
    public class HomeController : Controller
    {
        private readonly IIssueService ıssueService;
        private readonly IAppUserService appUserService;

        public HomeController(IIssueService ıssueService,IAppUserService appUserService)
        {
            this.ıssueService = ıssueService;
            this.appUserService = appUserService;
        }

        public ActionResult Index()
        {
            ViewBag.AppUser = appUserService.GetActive();
            ViewBag.OpenIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Open);
            ViewBag.CheckingIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Checking);
            ViewBag.ClosedIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Closed);
            return View();
        }

        
        public ActionResult Details(Guid id)
        {
            var ıssue = ıssueService.GetById(id);

            return View(ıssue);
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult UpdateStatus(Guid id)
        {
            var ıssue = ıssueService.GetById(id);
            ıssue.IssueStatus = DAL.Entities.Enum.IssueStatus.Checking;
            ıssueService.Update(ıssue);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult ClosedDetails(Guid id)
        {
            ViewBag.AppUser = appUserService.GetActive();
            var ıssue = ıssueService.GetById(id);
            return View(ıssue);
        }

        public ActionResult Edit(Guid id)
        {
            ViewBag.AppUser = appUserService.GetActive();
            var ıssue = ıssueService.GetById(id);
            return View(ıssue);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Issue ıssue)
        {
            try
            {
                ıssue.IssueStatus = DAL.Entities.Enum.IssueStatus.Closed;
                ıssueService.Update(ıssue);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            return View();
        }

        
    }
}
