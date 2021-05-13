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
    public class SupplierService : ISupplierService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public SupplierService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }
        public void Create(Supplier entity)
        {
            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();
            
            _context.Suppliers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Supplier entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<Supplier> GetActive()
        {
            return _context.Suppliers.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();

        }

        public List<Supplier> GetByDefault(Expression<Func<Supplier, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Suppliers.Where(filter).ToList();
            }
            else
            {
                return _context.Suppliers.ToList();
            }
        }

        public Supplier GetById(Guid id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.Id == id);

        }

        public void Update(Supplier entity)
        {
            entity.UpdatedBy = _signInManager.Context.User.Identity.Name;
            entity.UpdatedComputerName = Environment.MachineName;
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();
            entity.Status = DAL.Entities.Enum.Status.Updated;


            _context.Suppliers.Update(entity);
            _context.SaveChanges();
        }
    }
}
