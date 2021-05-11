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
        private readonly IOrderService orderService;
        private readonly IAppUserService appUserService;
        private readonly ICustomerService customerService;
        private readonly IProductService productService;
        private readonly IOrderDetailService orderDetailService;

        public HomeController(IOrderService orderService,IAppUserService appUserService,ICustomerService customerService,IProductService productService,IOrderDetailService orderDetailService)
        {
            this.orderService = orderService;
            this.appUserService = appUserService;
            this.customerService = customerService;
            this.productService = productService;
            this.orderDetailService = orderDetailService;
        }

        public ActionResult Index()
        {
            ViewBag.Customer = customerService.GetActive();
            ViewBag.AppUser = appUserService.UserList();
            var productWaiting = orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.ProductWaiting);
            return View(productWaiting);
        }


        public ActionResult OrderDetail(Guid id)
        {
            var order = orderService.GetById(id);
            var orderDetail = orderDetailService.GetByDefault(x => x.OrderId == order.Id);
            ViewBag.OrderId = order.Id;
            ViewBag.Product = productService.GetActive();
            var user = appUserService.GetByDefault(x=>x.Id==order.AppUserId);
            ViewBag.User = user;

            return View(orderDetail);
        }


        public ActionResult ProductDelivred(Guid id)
        {
            var order = orderService.GetById(id);
            order.OrderStatus = DAL.Entities.Enum.OrderStatus.Completed;
            order.Status = DAL.Entities.Enum.Status.Active;
            orderService.Update(order);

            return RedirectToAction("Index");
        }
    }
}
