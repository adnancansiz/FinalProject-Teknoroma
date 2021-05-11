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
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext context;

        public CategoryService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Category entity)
        {
            context.Categories.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            var deleted = context.Categories.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();

        }

        public List<Category> GetActive()
        {
            return context.Categories.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<Category> GetByDefault(Expression<Func<Category, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Categories.Where(filter).ToList();
            }
            else
            {
                return context.Categories.ToList();
            }
        }

        public Category GetById(Guid id)
        {
            var category = context.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public void Update(Category entity)
        {
            context.Categories.Update(entity);
            context.SaveChanges();
        }
    }
}
