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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public SubCategoryService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }
        public void Create(SubCategory entity)
        {

            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            _context.SubCategories.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(SubCategory entity)
        {

            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<SubCategory> GetActive()
        {
            return _context.SubCategories.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<SubCategory> GetByDefault(Expression<Func<SubCategory, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.SubCategories.Where(filter).ToList();
            }
            else
            {
                return _context.SubCategories.ToList();
            }
        }

        public SubCategory GetById(Guid id)
        {
            return _context.SubCategories.FirstOrDefault(x => x.Id == id);
        }

        public void Update(SubCategory entity)
        {
            entity.UpdatedBy = _signInManager.Context.User.Identity.Name;
            entity.UpdatedComputerName = Environment.MachineName;
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();
            entity.Status = DAL.Entities.Enum.Status.Updated;

            _context.SubCategories.Update(entity);
            _context.SaveChanges();
        }
    }
}
