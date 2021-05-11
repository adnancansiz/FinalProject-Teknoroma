using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IssueController : Controller
    {
        private readonly IIssueService ıssueService;
        private readonly IAppUserService appUserService;

        public IssueController(IIssueService ıssueService,IAppUserService appUserService)
        {
            this.ıssueService = ıssueService;
            this.appUserService = appUserService;
        }

        public ActionResult Index()
        {
            ViewBag.User = appUserService.GetActive();
            ViewBag.OpenIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Open);
            ViewBag.CheckingIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Checking);
            ViewBag.ClosedIssue = ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Closed);
            return View();
        }

        
        public ActionResult Create()
        {
            ViewBag.AppUser = appUserService.GetActive();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Issue ıssue)
        {
            try
            {
                ıssue.IssueStatus = DAL.Entities.Enum.IssueStatus.Open;
                ıssueService.Create(ıssue);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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
                ıssueService.Update(ıssue);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(Guid id)
        {
            var ıssue = ıssueService.GetById(id);
            ıssueService.Delete(ıssue);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
