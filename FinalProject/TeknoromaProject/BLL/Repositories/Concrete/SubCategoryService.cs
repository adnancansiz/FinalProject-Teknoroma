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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ApplicationDbContext context;

        public SubCategoryService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Create(SubCategory entity)
        {
            context.SubCategories.Add(entity);
            context.SaveChanges();
        }

        public void Delete(SubCategory entity)
        {
            var deleted = context.SubCategories.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);
            context.SaveChanges();
        }

        public List<SubCategory> GetActive()
        {
            return context.SubCategories.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<SubCategory> GetByDefault(Expression<Func<SubCategory, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.SubCategories.Where(filter).ToList();
            }
            else
            {
                return context.SubCategories.ToList();
            }
        }

        public SubCategory GetById(Guid id)
        {
            return context.SubCategories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(SubCategory entity)
        {
            context.SubCategories.Update(entity);
            context.SaveChanges();
        }
    }
}
