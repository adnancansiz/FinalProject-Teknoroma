using BLL.Repositories.Abstract;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace BLL.Repositories.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ICustomerService _customerService;

        public OrderService(ApplicationDbContext context, IOrderDetailService orderDetailService,IProductService productService, SignInManager<AppUser> signInManager,ICustomerService customerService)
        {
            _context = context;
            _orderDetailService = orderDetailService;
            _productService = productService;
            _signInManager = signInManager;
            _customerService = customerService;
        }

        public Order AddOrderDetailInOrder(OrderDetail orderDetail)
        {
            var orders = _orderDetailService.GetByDefault(x => x.OrderId == orderDetail.OrderId);
            var detail = orders.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
            var product = _productService.GetById(orderDetail.ProductId);

            var order = GetById(orderDetail.OrderId);

            if (orders != null)
            {
                if (detail == null)
                {
                    orderDetail.UnitPrice = product.UnitPrice;
                    _orderDetailService.Create(orderDetail);
                    product.UnıtsInStock -= orderDetail.Quantity;
                    _productService.Update(product);

                    return order ;
                }
                else
                {
                   
                    detail.Quantity += orderDetail.Quantity;

                    product.UnıtsInStock -= orderDetail.Quantity;
                    _productService.Update(product);

                    _orderDetailService.Update(detail);
                    return order;
                }
            }
            else
            {
                orderDetail.UnitPrice = product.UnitPrice;
                product.UnıtsInStock -= orderDetail.Quantity;
                _productService.Update(product);
                _orderDetailService.Create(orderDetail);

                return order;

            }
        }

        public void Create(Order entity)
        {
            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();


            _context.Orders.Add(entity);
            _context.SaveChanges();
        }

        public bool CreateOrder(Order order)
        {


            if (order.CustomerId == Guid.Empty)
            {
                var customer = _customerService.FindByTC(order.Customer.TC);
                if (customer == null)
                {
                    return false;
                }
                order.Customer = customer;
                order.CustomerId = customer.Id;
            }

            if (order.Id == Guid.Empty)
            {
                Create(order);
                order.OrderStatus = DAL.Entities.Enum.OrderStatus.Created;
                Update(order);
            }
            else
            {
                var orderList = _orderDetailService.GetByDefault(x => x.OrderId == order.Id);

              //  TempData["OrderList"] = orderList;
            }

            return true;
        }

        public void Delete(Order entity)
        {

            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<Order> GetActive()
        {
            return _context.Orders.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<Order> GetByDefault(Expression<Func<Order, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Orders.Where(filter).ToList();
            }
            else
            {
                return _context.Orders.ToList();
            }
        }

        public Order GetById(Guid id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order entity)
        {
            entity.UpdatedBy = _signInManager.Context.User.Identity.Name;
            entity.UpdatedComputerName = Environment.MachineName;
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            if (entity.Status == DAL.Entities.Enum.Status.Deleted)
            {

            }
            else
            {

                entity.Status = DAL.Entities.Enum.Status.Updated;
            }

            _context.Orders.Update(entity);
            _context.SaveChanges();
        }
    }
}
