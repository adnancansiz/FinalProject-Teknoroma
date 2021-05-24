using BLL.Repositories.Abstract;
using BLL.ViewModels.ApiVM;
using BLL.ViewModels.ReportsVM;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace BLL.Repositories.Concrete
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public ProductService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public void Create(Product entity)
        {
            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Product entity)
        {

            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<Product> GetActive()
        {
            return _context.Products.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<ProductVM> GetAllProductForApi()
        {
            var query = from p in _context.Products
                        select new ProductVM
                        {
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice,
                            UnıtsInStock = p.UnıtsInStock
                        };                     

            return query.ToList();

        }

        public List<Product> GetByDefault(Expression<Func<Product, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Products.Where(filter).ToList();
            }
            else
            {
                return _context.Products.ToList();
            }
        }

        public Product GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }


        public void Update(Product entity)
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


            if (entity.UnıtsInStock > 0)
            {
                _context.Products.Update(entity);
                _context.SaveChanges();

            }


        }
    }
}
