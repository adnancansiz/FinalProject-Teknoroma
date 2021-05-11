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
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext context;

        public CustomerService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Customer entity)
        {
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            var deleted = context.Customers.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public Customer FindByTC(string TC)
        {
            var customer = context.Customers.Where(x => x.TC == TC).FirstOrDefault();
            return customer;
        }

        public List<Customer> GetActive()
        {
            return context.Customers.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<Customer> GetByDefault(Expression<Func<Customer, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Customers.Where(filter).ToList();
            }
            else
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetById(Guid id)
        {
            var customer = context.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public void Update(Customer entity)
        {
            context.Customers.Update(entity);
            context.SaveChanges();
        }
    }
}
