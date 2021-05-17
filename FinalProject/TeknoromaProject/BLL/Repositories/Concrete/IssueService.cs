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
    public class IssueService : IIssueService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;

        public IssueService(ApplicationDbContext context, SignInManager<AppUser> signInManager)
        {
           _context = context;
           _signInManager = signInManager;
        }

        public void Create(Issue entity)
        {

            entity.CreatedBy = _signInManager.Context.User.Identity.Name;
            entity.CreatedComputerName = Environment.MachineName;
            entity.CreatedDate = DateTime.Now;
            entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();


            entity.IssueStatus = DAL.Entities.Enum.IssueStatus.Open;
            _context.Issues.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Issue entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Deleted;       
            
            //Todo : silinen bir ticket kapanmış olmak zorunda değil. Gözden kaçabilir.
            entity.IssueStatus = DAL.Entities.Enum.IssueStatus.Closed;
            Update(entity);
        }

        public List<Issue> GetActive()
        {
            return _context.Issues.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<Issue> GetByDefault(Expression<Func<Issue, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Issues.Where(filter).ToList();
            }
            else
            {
                return _context.Issues.ToList();
            }
        }

        public Issue GetById(Guid id)
        {
            return _context.Issues.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Issue entity)
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

            _context.Issues.Update(entity);
            _context.SaveChanges();
        }
    }
}
