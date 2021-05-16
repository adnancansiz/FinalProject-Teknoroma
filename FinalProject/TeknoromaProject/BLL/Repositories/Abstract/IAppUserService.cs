using BLL.ViewModels;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        void UserAddRole(AppUser user, Guid roleid);

        void MonthlySalesBonus(List<OrderDetail> orderDetails, AppUser user);

        AppUser Register(AppUser register);

        List<AppUser> UserList();
    }
}
