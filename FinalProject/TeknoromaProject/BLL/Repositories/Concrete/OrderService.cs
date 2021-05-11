using BLL.Repositories.Abstract;
using DAL.Context;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repositories.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext context;

        public OrderService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Order entity)
        {
            
            context.Orders.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Order entity)
        {
            var deleted = context.Orders.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public List<Order> GetActive()
        {
            return context.Orders.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<Order> GetByDefault(Expression<Func<Order, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Orders.Where(filter).ToList();
            }
            else
            {
                return context.Orders.ToList();
            }
        }

        public Order GetById(Guid id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order entity)
        {
            context.Orders.Update(entity);
            context.SaveChanges();
        }
    }
}
