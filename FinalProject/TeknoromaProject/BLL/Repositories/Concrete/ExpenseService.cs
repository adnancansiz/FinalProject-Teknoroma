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
    public class ExpenseService : IExpenseService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public ExpenseService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
           _context = context;
           _signInManager = signInManager;
        }

        public void Create(Expense entity)
        {
            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

            entity.Status = DAL.Entities.Enum.Status.Active;
            _context.Expenses.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Expense entity)
        {

            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<Expense> GetActive()
        {
            return _context.Expenses.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<Expense> GetByDefault(Expression<Func<Expense, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Expenses.Where(filter).ToList();
            }
            else
            {
                return _context.Expenses.ToList();
            }
        }

        public Expense GetById(Guid id)
        {
            return _context.Expenses.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Expense entity)
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

            _context.Expenses.Update(entity);
            _context.SaveChanges();
        }
    }
}
