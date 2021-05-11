using BLL.Repositories.Abstract;
using BLL.Repositories.Concrete;
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
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly ISubCategoryService subCategoryService;

        public CategoryController(ICategoryService categoryService,ISubCategoryService subCategoryService)
        {
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;
        }

        public ActionResult Index()
        {
            ViewBag.subCategory = subCategoryService.GetActive();
            return View(categoryService.GetActive());
        }


       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            categoryService.Create(category);
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(Guid id)
        {
            var update = categoryService.GetById(id);
            return View(update);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {
                categoryService.Update(category);
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
                var delete = categoryService.GetById(id);
                categoryService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
