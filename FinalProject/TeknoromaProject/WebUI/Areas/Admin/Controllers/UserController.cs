using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public UserController(IAppUserService appUserService,RoleManager<AppRole> roleManager,UserManager<AppUser> userManager)
        {
            _appUserService = appUserService;
           _roleManager = roleManager;
           _userManager = userManager;
        }

        public ActionResult Index()
        {
            return View(_appUserService.GetActive());
        }


        
        public ActionResult Create()
        {
            ViewBag.Roles = _roleManager.Roles.ToList();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create(AppUser appUser, Guid roleid)
        {
            if (ModelState.IsValid)
            {

               var exist = _appUserService.Register(appUser);

                if (exist.Id != Guid.Empty)
                {
                    _appUserService.UserAddRole(exist, roleid);
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Exist"] = $"{appUser.UserName} Kullanıcısı zaten mevcut";
                    return RedirectToAction("Index");

                }

            }
            else
            {
                
                return View(appUser);
            }
            
        }

        public ActionResult Edit(Guid id)
        {
            ViewBag.Roles = _roleManager.Roles.ToList();

            var update = _appUserService.GetById(id);

            return View(update);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AppUser appUser,Guid roleId)
        {
            try
            {
                _appUserService.Update(appUser);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        
        public ActionResult Delete(Guid id)
        {
            try
            {
                var delete = _appUserService.GetById(id);
                _appUserService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
