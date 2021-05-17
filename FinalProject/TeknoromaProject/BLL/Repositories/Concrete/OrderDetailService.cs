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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public OrderDetailService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }
        public void Create(OrderDetail entity)
        {

            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            entity.Id = Guid.NewGuid();
            _context.OrderDetails.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
        {

            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);


        }

        public List<OrderDetail> GetActive()
        {
            return _context.OrderDetails.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<OrderDetail> GetByDefault(Expression<Func<OrderDetail, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.OrderDetails.Where(filter).ToList();
            }
            else
            {
                return _context.OrderDetails.ToList();
            }
        }

        public OrderDetail GetById(Guid id)
        {
            return _context.OrderDetails.FirstOrDefault(x => x.Id == id);
        }

        public void Update(OrderDetail entity)
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


            _context.OrderDetails.Update(entity);
            _context.SaveChanges();
        }
    }
}
