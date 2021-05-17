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
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories.Concrete
{
    public class AppUserService : IAppUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AppUserService(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
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
            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);

        }

        public List<AppUser> GetActive()
        {
            return _context.Users.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();
        }

        public List<AppUser> GetByDefault(Expression<Func<AppUser, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.Users.Where(filter).ToList();
            }
            else
            {
                return _context.Users.ToList();
            }
        }

        public AppUser GetById(Guid id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void MonthlySalesBonus(List<OrderDetail> orderDetails, AppUser user)
        {
            var limit = 10000;
            var cut = 0.1;
            foreach(OrderDetail od in orderDetails)
            {
                if (user.MonthlySales <= limit)
                {

                    user.MonthlySales += od.UnitPrice * od.Quantity;

                    if (user.MonthlySales > limit)
                    {
                        var addBonus = user.MonthlySales - limit;
                        user.Bonus += addBonus * (decimal)cut;
                    }

                }
                else
                {
                    user.Bonus += (user.MonthlySales - limit) * (decimal)cut;
                    user.Bonus += (od.UnitPrice * od.Quantity) * (decimal)cut;
                }
            }

            Update(user);
        }

        public AppUser Register(AppUser register)
        {

            var existEmail = _userManager.FindByEmailAsync(register.Email).Result;
            var existUserName = _userManager.FindByNameAsync(register.UserName).Result;
            if (existEmail != null || existUserName != null)
            {
                return register;
            }
            else
            {
                var createdBy = string.Empty;
                if (_signInManager.Context.User.Identity.Name != null)
                {
                    createdBy = _signInManager.Context.User.Identity.Name;
                }
                else
                {
                    createdBy = register.UserName;
                }
                AppUser user = new AppUser
                {
                    UserName = register.UserName,
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    Email = register.Email,
                    PhoneNumber = register.PhoneNumber,
                    Address = register.Address,
                    Status = DAL.Entities.Enum.Status.Active,
                    CreatedBy = createdBy,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = Environment.MachineName,
                    CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString()

                };

                var result = _userManager.CreateAsync(user, register.Password).Result;
                _context.SaveChanges();

                return user;

            }
        }

        public void Update(AppUser entity)
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

            //Todo : Upade sorunu SecrutySpam ile ilgili araştırılıcak.

            var result = _userManager.UpdateAsync(entity).Result;
            _context.SaveChanges();
        }

        public void UserAddRole(AppUser user, Guid roleid)
        {
          var roles =   _context.Roles.FirstOrDefault(x => x.Id == roleid);
           
           var result = _userManager.AddToRoleAsync(user, roles.Name).Result;
            _context.SaveChanges();
        }

        public List<AppUser> UserList()
        {
           return _context.Users.ToList();
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
