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

        // POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult  Create(AppUser appUser, Guid roleid)
        //{
        //    try
        //    {
        //        appUserService.Create(appUser);
        //        appUserService.UserAddRole(appUser, roleid);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AppUser appUser, Guid roleid)
        {
            if (ModelState.IsValid)
            {

               var exist = _appUserService.Register(appUser);

                if (!exist)
                {
                    _appUserService.UserAddRole(appUser, roleid);

                }
                else
                {
                    TempData["Exist"] = "Kullanıcı zaten mevcut"; 
                }

                AppUser user = new AppUser
                {
                    UserName = appUser.UserName,
                    FirstName = appUser.FirstName,
                    LastName = appUser.LastName,
                    Email = appUser.Email,
                    PhoneNumber = appUser.PhoneNumber,
                    Address = appUser.Address,
                    Status= appUser.Status,
                    
                };
                user.Status = DAL.Entities.Enum.Status.Active;
                var result = await _userManager.CreateAsync(user, appUser.Password);
                if (result.Succeeded)
                {
                    //var role = roleManager.Roles.FirstOrDefault(x => x.Id == roleid);
                    //var roleName = role.Name;
                    //userManager.AddToRoleAsync(user, roleName).Wait();
                    _appUserService.UserAddRole(user, roleid);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return View(appUser);
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
        public ActionResult Edit(AppUser appUser)
        {
            try
            {
                _appUserService.Update(appUser);
                return RedirectToAction(nameof(Index));
            }
            catch
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
