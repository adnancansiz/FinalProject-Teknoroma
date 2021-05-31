using BLL.Repositories.Abstract;
using BLL.ViewModels;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IAppUserService _appUserService;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IAppUserService appUserService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appUserService = appUserService;
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = registerVM.UserName,
                    Email = registerVM.Email

                };
                var result = await _userManager.CreateAsync(user, registerVM.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return View(registerVM);
                }

            }
            else
            {
                return View(registerVM);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var user = _userManager.FindByNameAsync(loginVM.UserName).Result;

            if (user != null)
            {
                var result = _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.IsPersistant, false).Result;
                if (result.Succeeded)
                {
                    string area = _appUserService.AreaLogin(user);
                    return Redirect($"/{area}/Home/Index");
                }
                return View();
            }
            return View();

        }

       
        public async Task<IActionResult> LogOut(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            }
            return RedirectToAction("Login");

        }

    }
}
