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
    public class SupplierService : ISupplierService
    {
        private readonly ApplicationDbContext context;

        public SupplierService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Create(Supplier entity)
        {
            context.Suppliers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Supplier entity)
        {
            var deleted = context.Suppliers.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);
            context.SaveChanges();
        }

        public List<Supplier> GetActive()
        {
            return context.Suppliers.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();

        }

        public List<Supplier> GetByDefault(Expression<Func<Supplier, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Suppliers.Where(filter).ToList();
            }
            else
            {
                return context.Suppliers.ToList();
            }
        }

        public Supplier GetById(Guid id)
        {
            return context.Suppliers.FirstOrDefault(x => x.Id == id);

        }

        public void Update(Supplier entity)
        {
            context.Suppliers.Update(entity);
            context.SaveChanges();
        }
    }
}
