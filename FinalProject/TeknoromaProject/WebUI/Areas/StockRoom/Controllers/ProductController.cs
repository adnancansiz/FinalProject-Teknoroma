using BLL.Repositories.Abstract;
using Common;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.StockRoom.Controllers
{
    [Area("StockRoom")]
    [Authorize(Roles = "StockRoom")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly ISupplierService _supplierService;

        public ProductController(IProductService productService, ISubCategoryService subCategoryService, ISupplierService supplierService)
        {
           _productService = productService;
           _subCategoryService = subCategoryService;
            _supplierService = supplierService;
        }

        public ActionResult Index()
        {
            ViewBag.subCategories = _subCategoryService.GetActive();
            ViewBag.suppliers = _supplierService.GetActive();
            return View(_productService.GetActive());
        }


        public ActionResult Create()
        {
            ViewBag.subCategories = _subCategoryService.GetActive();
            ViewBag.suppliers = _supplierService.GetActive();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (product.ImageFile == null)
                {
                    product.ImageName = "resimyok.jpg";
                }
                else
                {

                    ImageUploader.ProductImageUploader(product);
                }
                _productService.Create(product);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        public ActionResult Edit(Guid id)
        {
            ViewBag.subCategories = _subCategoryService.GetActive();
            var update = _productService.GetById(id);
            return View(update);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                _productService.Update(product);
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
                var delete = _productService.GetById(id);
                _productService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
