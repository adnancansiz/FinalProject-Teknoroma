using BLL.Repositories.Abstract;
using BLL.ViewModels;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<AppUser> userManager;

        public AppUserService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public void Create(AppUser entity)
        {
            //AppUser user = new AppUser
            //{
            //    UserName = entity.UserName,
            //    FirstName = entity.FirstName,
            //    LastName = entity.LastName,
            //    Email = entity.Email,
            //    PhoneNumber = entity.PhoneNumber,
            //    Address = entity.Address
                
            //};
            //var result = userManager.CreateAsync(user, entity.Password);
            //context.SaveChanges();
        }

        public void Delete(AppUser entity)
        {
            var deleted = context.Users.FirstOrDefault(x => x.Id == entity.Id);
            deleted.Status = DAL.Entities.Enum.Status.Deleted;
            Update(deleted);
            context.SaveChanges();
        }

        public List<AppUser> GetActive()
        {
            return context.Users.Where(x => x.Status == DAL.Entities.Enum.Status.Active).ToList();
        }

        public List<AppUser> GetByDefault(Expression<Func<AppUser, bool>> filter = null)
        {
            if (filter != null)
            {
                return context.Users.Where(filter).ToList();
            }
            else
            {
                return context.Users.ToList();
            }
        }

        public AppUser GetById(Guid id)
        {
            var user = context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void Update(AppUser entity)
        {
            context.Users.Update(entity);
            context.SaveChanges();
        }

        public void UserAddRole(AppUser user, Guid roleid)
        {
            var role = context.Roles.FirstOrDefault(x => x.Id == roleid);
            var roleName = role.Name;

            userManager.AddToRoleAsync(user, roleName).Wait();
            context.SaveChanges();
        }

        public List<AppUser> UserList()
        {
           return context.Users.ToList();
        }

        //public async Task<IActionResult> CreateUser(AppUser entity)
        //{
        //    AppUser user = new AppUser
        //    {
        //        UserName = entity.UserName,
        //        FirstName = entity.FirstName,
        //        LastName = entity.LastName,
        //        Email = entity.Email,
        //        PhoneNumber = entity.PhoneNumber,
        //        Address = entity.Address,
        //        Password = entity.Password
        //    };
        //    var result = await userManager.CreateAsync(user, entity.Password);
        //    context.SaveChanges();

        //}
    }
}
