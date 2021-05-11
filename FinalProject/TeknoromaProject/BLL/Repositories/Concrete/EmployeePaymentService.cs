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
    public class EmployeePaymentService : IEmployeePaymentService
    {
        private readonly ApplicationDbContext context;

        public EmployeePaymentService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(EmployeePayment entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Active;
            context.EmployeePayments.Add(entity);
            context.SaveChanges();
        }

        public void Delete(EmployeePayment entity)
        {
            var deleted = context.EmployeePayments.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public List<EmployeePayment> GetActive()
        {
            return context.EmployeePayments.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<EmployeePayment> GetByDefault(Expression<Func<EmployeePayment, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.EmployeePayments.Where(filter).ToList();
            }
            else
            {
                return context.EmployeePayments.ToList();
            }
        }

        public EmployeePayment GetById(Guid id)
        {
            return context.EmployeePayments.FirstOrDefault(x => x.Id == id);
        }

        public void Update(EmployeePayment entity)
        {
            context.EmployeePayments.Update(entity);
            context.SaveChanges();
        }
    }
}
