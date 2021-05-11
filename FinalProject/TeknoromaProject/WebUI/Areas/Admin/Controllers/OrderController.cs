﻿using BLL.Repositories.Abstract;
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
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IOrderDetailService orderDetailService;
        private readonly ICustomerService customerService;
        private readonly IProductService productService;
        private readonly IAppUserService appUserService;

        public OrderController(IOrderService orderService,IOrderDetailService orderDetailService,ICustomerService customerService,IProductService productService,IAppUserService appUserService)
        {
            this.orderService = orderService;
            this.orderDetailService = orderDetailService;
            this.customerService = customerService;
            this.productService = productService;
            this.appUserService = appUserService;
        }

        public ActionResult Index()
        {
            ViewBag.Created = orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.Created);
            ViewBag.ProductWaiting = orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.ProductWaiting);
            ViewBag.Completed = orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.Completed);
            ViewBag.Customer = customerService.GetActive();
            ViewBag.AppUser = appUserService.UserList();
            return View();
        }

        public ActionResult CreateOrder()
        {
            ViewBag.Customer = customerService.GetActive();
            return View();
        }

        public ActionResult Create(Order order)
        {
            if (order.CustomerId == Guid.Empty)
            {
                var customer = customerService.FindByTC(order.Customer.TC);
                if (customer == null)
                {
                    return RedirectToAction("CreateOrder");
                }
                order.Customer = customer;
                order.CustomerId = customer.Id;
            }

            if (order.Id == Guid.Empty)
            {
                orderService.Create(order);
                order.OrderStatus = DAL.Entities.Enum.OrderStatus.Created;
                orderService.Update(order);
            }
            else
            {
                var orderList = orderDetailService.GetByDefault(x => x.OrderId == order.Id);

                TempData["OrderList"] = orderList;
            }

            var products = productService.GetActive();

            ViewBag.Products = products;
            ViewBag.OrderId = order.Id;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetail orderDetail)
        {
            try
            {
                var orders = orderDetailService.GetByDefault(x => x.OrderId == orderDetail.OrderId);
                var detail = orders.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
                var product = productService.GetById(orderDetail.ProductId);
                
                var order = orderService.GetById(orderDetail.OrderId);
                if (orders != null)
                {
                    if (detail == null)
                    {
                        orderDetail.UnitPrice = product.UnitPrice;
                        orderDetailService.Create(orderDetail);


                        return RedirectToAction("Create", order);
                    }
                    else
                    {
                        var qua = orderDetail.Quantity;
                        detail.Quantity += qua;
                        orderDetailService.Update(detail);
                        return RedirectToAction("Create", order);
                    }
                }
                else
                {
                    orderDetail.UnitPrice = product.UnitPrice;
                    orderDetailService.Create(orderDetail);


                    return RedirectToAction("Create", order);
                }
                

            }
            catch(Exception ex)
            {
                throw;
            }
        }


        public ActionResult OrderDone(Guid OrderId)
        {
            var order = orderService.GetById(OrderId);
            order.Status = DAL.Entities.Enum.Status.Active;
            order.OrderStatus = DAL.Entities.Enum.OrderStatus.ProductWaiting;
            orderService.Update(order);

            return RedirectToAction("Index");
        }


        public ActionResult Detail(Guid id)
        {
            var order = orderService.GetById(id);

            if (order.CustomerId == Guid.Empty)
            {
                var customer = customerService.FindByTC(order.Customer.TC);
                if (customer == null)
                {
                    return RedirectToAction("CreateOrder");
                }
                order.Customer = customer;
                order.CustomerId = customer.Id;
            }

            if (order.Id == Guid.Empty)
            {
                orderService.Create(order);
                order.OrderStatus = DAL.Entities.Enum.OrderStatus.Created;
                orderService.Update(order);
            }
            else
            {
                var orderList = orderDetailService.GetByDefault(x => x.OrderId == order.Id);

                TempData["OrderList"] = orderList;
            }

            var products = productService.GetActive();

            ViewBag.Products = products;
            ViewBag.OrderId = order.Id;
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
