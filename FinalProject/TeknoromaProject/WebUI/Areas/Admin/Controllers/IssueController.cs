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
        private readonly IIssueService _ıssueService;
        private readonly IAppUserService _appUserService;

        public IssueController(IIssueService ıssueService,IAppUserService appUserService)
        {
            _ıssueService = ıssueService;
            _appUserService = appUserService;
        }

        public ActionResult Index()
        {
            ViewBag.User = _appUserService.GetActive();
            ViewBag.OpenIssue = _ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Open);
            ViewBag.CheckingIssue = _ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Checking);
            ViewBag.ClosedIssue = _ıssueService.GetByDefault(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Closed);
            return View();
        }

        
        public ActionResult Create()
        {
            ViewBag.AppUser = _appUserService.GetActive();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Issue ıssue)
        {
            try
            {
                ıssue.IssueStatus = DAL.Entities.Enum.IssueStatus.Open;
                _ıssueService.Create(ıssue);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(Guid id)
        {
            ViewBag.AppUser = _appUserService.GetActive();
            var ıssue = _ıssueService.GetById(id);
            return View(ıssue);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Issue ıssue)
        {
            try
            {
                _ıssueService.Update(ıssue);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(Guid id)
        {
            var ıssue = _ıssueService.GetById(id);
            _ıssueService.Delete(ıssue);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
