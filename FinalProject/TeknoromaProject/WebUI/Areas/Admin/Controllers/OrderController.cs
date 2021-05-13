﻿using BLL.Repositories.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IAppUserService _appUserService;
        private readonly SignInManager<AppUser> _signInManager;

        public OrderController(IOrderService orderService,IOrderDetailService orderDetailService,ICustomerService customerService,IProductService productService,IAppUserService appUserService, SignInManager<AppUser> signInManager)
        {
          _orderService = orderService;
          _orderDetailService = orderDetailService;
          _customerService = customerService;
          _productService = productService;
          _appUserService = appUserService;
            _signInManager = signInManager;
        }

        public ActionResult Index()
        {
            ViewBag.Created = _orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.Created);
            ViewBag.ProductWaiting = _orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.ProductWaiting);
            ViewBag.Completed = _orderService.GetByDefault(x => x.OrderStatus == DAL.Entities.Enum.OrderStatus.Completed);
            ViewBag.Customer = _customerService.GetActive();
            ViewBag.AppUser = _appUserService.UserList();
            return View();
        }

        public ActionResult CreateOrder()
        {
            ViewBag.Customer = _customerService.GetActive();
           var userName = _signInManager.Context.User.Identity.Name;

            var customers = _appUserService.GetByDefault(x => x.UserName == userName);
            ViewBag.CustomerId = customers[0].Id;

            return View();
        }

        public ActionResult Create(Order order)
        {
            if (order.CustomerId == Guid.Empty)
            {
                var customer = _customerService.FindByTC(order.Customer.TC);
                if (customer == null)
                {
                    return RedirectToAction("CreateOrder");
                }
                order.Customer = customer;
                order.CustomerId = customer.Id;
            }

            if (order.Id == Guid.Empty)
            {
                _orderService.Create(order);
                order.OrderStatus = DAL.Entities.Enum.OrderStatus.Created;
                _orderService.Update(order);
            }
            else
            {
                var orderList = _orderDetailService.GetByDefault(x => x.OrderId == order.Id);

                TempData["OrderList"] = orderList;
            }

            var products = _productService.GetActive();

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
               var order = _orderService.AddOrderDetailInOrder(orderDetail);

                return RedirectToAction("Create",order);

                //var orders = _orderDetailService.GetByDefault(x => x.OrderId == orderDetail.OrderId);
                //var detail = orders.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
                //var product = productService.GetById(orderDetail.ProductId);

                //var order = _orderService.GetById(orderDetail.OrderId);
                //if (orders != null)
                //{
                //    if (detail == null)
                //    {
                //        orderDetail.UnitPrice = product.UnitPrice;
                //        _orderDetailService.Create(orderDetail);


                //        return RedirectToAction("Create", order);
                //    }
                //    else
                //    {
                //        var qua = orderDetail.Quantity;
                //        detail.Quantity += qua;
                //        _orderDetailService.Update(detail);
                //        return RedirectToAction("Create", order);
                //    }
                //}
                //else
                //{
                //    orderDetail.UnitPrice = product.UnitPrice;
                //    _orderDetailService.Create(orderDetail);


                //    return RedirectToAction("Create", order);
                //}

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public ActionResult OrderDone(Guid OrderId)
        {
            var order = _orderService.GetById(OrderId);
            order.Status = DAL.Entities.Enum.Status.Active;
            order.OrderStatus = DAL.Entities.Enum.OrderStatus.ProductWaiting;
            _orderService.Update(order);

            return RedirectToAction("Index");
        }


        public ActionResult Detail(Guid id)
        {
            var order = _orderService.GetById(id);

            if (order.CustomerId == Guid.Empty)
            {
                var customer = _customerService.FindByTC(order.Customer.TC);
                if (customer == null)
                {
                    return RedirectToAction("CreateOrder");
                }
                order.Customer = customer;
                order.CustomerId = customer.Id;
            }

            if (order.Id == Guid.Empty)
            {
                _orderService.Create(order);
                order.OrderStatus = DAL.Entities.Enum.OrderStatus.Created;
                _orderService.Update(order);
            }
            else
            {
                var orderList = _orderDetailService.GetByDefault(x => x.OrderId == order.Id);

                TempData["OrderList"] = orderList;
            }

            var products = _productService.GetActive();

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
