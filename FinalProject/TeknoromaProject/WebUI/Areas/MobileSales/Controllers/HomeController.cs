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

namespace WebUI.Areas.MobileSales.Controllers
{
    [Area("MobileSales")]
    [Authorize(Roles = "MobileSales")]
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(SignInManager<AppUser> signInManager)
        {

            _signInManager = signInManager;
        }

        public ActionResult Index()
        {
            var user = _signInManager.UserManager.FindByNameAsync(User.Identity.Name).Result;

            return View(user);
        }
    }
}
