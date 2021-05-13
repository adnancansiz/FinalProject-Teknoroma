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
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;

        public SubCategoryController(ISubCategoryService subCategoryService,ICategoryService categoryService)
        {
           _subCategoryService = subCategoryService;
           _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetActive();
            return View(_subCategoryService.GetActive());
        }


        public ActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetActive();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubCategory subCategory)
        {
            try
            {
                _subCategoryService.Create(subCategory);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(Guid id)
        {
            ViewBag.Categories = _categoryService.GetActive();
            var update = _subCategoryService.GetById(id);
            return View(update);
        }

        // POST: SubCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SubCategory subCategory)
        {
            try
            {
                _subCategoryService.Update(subCategory);
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
                var delete = _subCategoryService.GetById(id);
                _subCategoryService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
