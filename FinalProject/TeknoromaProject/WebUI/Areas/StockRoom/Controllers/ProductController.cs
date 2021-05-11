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
        private readonly IProductService productService;
        private readonly ISubCategoryService subCategoryService;
        private readonly ISupplierService supplierService;

        public ProductController(IProductService productService, ISubCategoryService subCategoryService, ISupplierService supplierService)
        {
            this.productService = productService;
            this.subCategoryService = subCategoryService;
            this.supplierService = supplierService;
        }

        public ActionResult Index()
        {
            ViewBag.subCategories = subCategoryService.GetActive();
            ViewBag.suppliers = supplierService.GetActive();
            return View(productService.GetActive());
        }


        public ActionResult Create()
        {
            ViewBag.subCategories = subCategoryService.GetActive();
            ViewBag.suppliers = supplierService.GetActive();
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
                productService.Create(product);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }


        public ActionResult Edit(Guid id)
        {
            ViewBag.subCategories = subCategoryService.GetActive();
            var update = productService.GetById(id);
            return View(update);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            try
            {
                productService.Update(product);
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
                var delete = productService.GetById(id);
                productService.Delete(delete);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
