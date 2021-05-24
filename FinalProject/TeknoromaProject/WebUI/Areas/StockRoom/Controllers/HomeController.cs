using BLL.Repositories.Abstract;
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
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IAppUserService _appUserService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IOrderDetailService _orderDetailService;

        public HomeController(IOrderService orderService,IAppUserService appUserService,ICustomerService customerService,IProductService productService,IOrderDetailService orderDetailService)
        {
           _orderService = orderService;
           _appUserService = appUserService;
           _customerService = customerService;
           _productService = productService;
           _orderDetailService = orderDetailService;
        }

        public ActionResult Index()
        {
            ViewBag.Customer = _customerService.GetActive();
            ViewBag.AppUser = _appUserService.UserList();
            
            var productWaiting = _orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.ProductWaiting);
            return View(productWaiting);
        }


        public ActionResult OrderDetail(Guid id)
        {
            var order = _orderService.GetById(id);
            var orderDetail = _orderDetailService.GetByDefault(x => x.OrderId == order.Id);
            ViewBag.OrderId = order.Id;
            ViewBag.Product = _productService.GetActive();
            var user = _appUserService.GetByDefault(x=>x.Id==order.AppUserId);
            ViewBag.User = user;

            return View(orderDetail);
        }


        public ActionResult ProductDelivred(Guid id)
        {
            var order = _orderService.GetById(id);
            order.OrderStatus = DAL.Entities.Enum.OrderStatus.Completed;
            order.Status = DAL.Entities.Enum.Status.Active;
            _orderService.Update(order);

            return RedirectToAction("Index");
        }
    }
}
