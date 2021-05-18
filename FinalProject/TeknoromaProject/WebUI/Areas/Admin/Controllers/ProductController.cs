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

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly ISupplierService _supplierService;
        private readonly ISupplierExpenseService _supplierExpenseService;

        public ProductController(IProductService productService,ISubCategoryService subCategoryService,ISupplierService supplierService,ISupplierExpenseService supplierExpenseService)
        {
            _productService = productService;
            _subCategoryService = subCategoryService;
            _supplierService = supplierService;
            _supplierExpenseService = supplierExpenseService;
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
            catch(Exception ex)
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
            catch(Exception ex)
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

        public IActionResult AddStock(Guid id)
        {
            var product = _productService.GetById(id);
            var supplier = _supplierService.GetById(product.SupplierId);
            ViewBag.Supplier = supplier;
            ViewBag.Product = product;
            return View();
        }

        [HttpPost]
        public IActionResult AddStock(SupplierExpense supplierExpense)
        {
            try
            {
                _supplierExpenseService.Create(supplierExpense);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
