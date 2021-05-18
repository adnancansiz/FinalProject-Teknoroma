using BLL.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        private readonly IAppUserService appUserService;

        public HomeController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }

        public ActionResult Index()
        {
            var user = User.Identity.Name;
            var users = appUserService.GetByDefault(x => x.UserName == user);

            return View(users[0]);
        }
    }
}
