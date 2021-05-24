using BLL.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public IActionResult GetAllProduct()
        {
            try
            {
                var products = _productService.GetAllProductForApi();

                return Ok(products);


            }
            catch (Exception ex)
            {
                return StatusCode(500, "Servis Hatası");                
            }
        }

    }
}
