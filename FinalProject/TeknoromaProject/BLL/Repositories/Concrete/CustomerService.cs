using BLL.Repositories.Abstract;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace BLL.Repositories.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public CustomerService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        public void Create(Customer entity)
        {
            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            _context.Customers.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public Customer FindByTC(string TC)
        {
            var customer = _context.Customers.Where(x => x.TC == TC).FirstOrDefault();
            return customer;
        }

        public List<Customer> GetActive()
        {
            return _context.Customers.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<Customer> GetByDefault(Expression<Func<Customer, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Customers.Where(filter).ToList();
            }
            else
            {
                return _context.Customers.ToList();
            }
        }

        public Customer GetById(Guid id)
        {
            var entity = _context.Customers.AsNoTracking().Where(x => x.Id == id).ToList();
            return entity[0];
        }

        public void Update(Customer entity)
        {
            var exist = GetById(entity.Id);

            entity.UpdatedBy = _signInManager.Context.User.Identity.Name;
            entity.UpdatedComputerName = Environment.MachineName;
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            entity.CreatedIP = exist.CreatedIP;
            entity.CreatedDate = exist.CreatedDate;
            entity.CreatedComputerName = exist.CreatedComputerName;
            entity.CreatedBy = exist.CreatedBy;


            if (entity.Status == DAL.Entities.Enum.Status.Deleted)
            {
                entity.Status = DAL.Entities.Enum.Status.Deleted;
            }
            else
            {
                entity.Status = DAL.Entities.Enum.Status.Updated;
            }

            _context.Customers.Update(entity);

            _context.SaveChanges();

        }
    }
}
