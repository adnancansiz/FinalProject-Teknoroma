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
    public class ExpenseService : IExpenseService
    {
        private readonly ApplicationDbContext context;

        public ExpenseService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Expense entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Active;
            context.Expenses.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Expense entity)
        {
            var deleted = context.Expenses.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public List<Expense> GetActive()
        {
            return context.Expenses.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<Expense> GetByDefault(Expression<Func<Expense, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Expenses.Where(filter).ToList();
            }
            else
            {
                return context.Expenses.ToList();
            }
        }

        public Expense GetById(Guid id)
        {
            return context.Expenses.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Expense entity)
        {
            context.Expenses.Update(entity);
            context.SaveChanges();
        }
    }
}
