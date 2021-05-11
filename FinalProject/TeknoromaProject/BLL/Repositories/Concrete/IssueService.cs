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
    public class IssueService : IIssueService
    {
        private readonly ApplicationDbContext context;

        public IssueService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(Issue entity)
        {
            entity.IssueStatus = DAL.Entities.Enum.IssueStatus.Open;
            context.Issues.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Issue entity)
        {
            var deleted = context.Issues.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            deleted.IssueStatus = DAL.Entities.Enum.IssueStatus.Closed;
            context.Update(entity);
            context.SaveChanges();
        }

        public List<Issue> GetActive()
        {
            return context.Issues.Where(x => x.IssueStatus == DAL.Entities.Enum.IssueStatus.Open).ToList();
        }

        public List<Issue> GetByDefault(Expression<Func<Issue, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Issues.Where(filter).ToList();
            }
            else
            {
                return context.Issues.ToList();
            }
        }

        public Issue GetById(Guid id)
        {
            return context.Issues.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Issue entity)
        {
            context.Issues.Update(entity);
            context.SaveChanges();
        }
    }
}
