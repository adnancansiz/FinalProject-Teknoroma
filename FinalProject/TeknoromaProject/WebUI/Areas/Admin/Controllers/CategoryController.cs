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
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public CategoryController(ICategoryService categoryService,ISubCategoryService subCategoryService)
        {
           _categoryService = categoryService;
           _subCategoryService = subCategoryService;
        }

        public ActionResult Index()
        {
            ViewBag.subCategory = _subCategoryService.GetActive();
            return View(_categoryService.GetActive());
        }


       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            _categoryService.Create(category);
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(Guid id)
        {
            var update = _categoryService.GetById(id);
            return View(update);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {                
                _categoryService.Update(category);

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
                var delete = _categoryService.GetById(id);
                _categoryService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
