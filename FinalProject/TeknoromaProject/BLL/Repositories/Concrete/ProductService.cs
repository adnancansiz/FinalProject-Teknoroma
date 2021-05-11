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
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            var deleted = context.Products.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public List<Product> GetActive()
        {
            return context.Products.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<Product> GetByDefault(Expression<Func<Product, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Products.Where(filter).ToList();
            }
            else
            {
                return context.Products.ToList();
            }
        }

        public Product GetById(Guid id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Product entity)
        {
            context.Products.Update(entity);
            context.SaveChanges();
        }
    }
}
