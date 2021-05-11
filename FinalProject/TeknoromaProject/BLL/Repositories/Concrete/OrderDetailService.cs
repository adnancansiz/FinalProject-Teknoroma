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
    public class OrderDetailService : IOrderDetailService
    {
        private readonly ApplicationDbContext context;

        public OrderDetailService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Create(OrderDetail entity)
        {
            entity.Id = Guid.NewGuid();
            context.OrderDetails.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
        {
            var deleted = context.OrderDetails.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);
            context.SaveChanges();
        }

        public List<OrderDetail> GetActive()
        {
            return context.OrderDetails.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<OrderDetail> GetByDefault(Expression<Func<OrderDetail, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.OrderDetails.Where(filter).ToList();
            }
            else
            {
                return context.OrderDetails.ToList();
            }
        }

        public OrderDetail GetById(Guid id)
        {
            return context.OrderDetails.FirstOrDefault(x => x.Id == id);
        }

        public void Update(OrderDetail entity)
        {
            context.OrderDetails.Update(entity);
            context.SaveChanges();
        }
    }
}
