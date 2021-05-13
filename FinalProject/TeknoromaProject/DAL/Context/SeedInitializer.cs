using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class SeedInitializer
    {
        public static void SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);

        }

        private static void SeedUsers(UserManager<AppUser> userManager)
        {
            if (userManager.FindByNameAsync("testAdmin").Result == null)
            {
                AppUser user = new AppUser();
                user.UserName = "Admin";
                user.Email = "admin@admin.com";
                user.FirstName = "Admin";
                user.LastName = "Admin";
                user.Status = DAL.Entities.Enum.Status.Active;
                user.CreatedBy = "Test";
                user.CreatedComputerName = "Test";
                user.CreatedDate = DateTime.Now;
                user.CreatedIP = "^Test";

                var result = userManager.CreateAsync(user, "Test123++").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
                else
                {
                    foreach (var item in result.Errors)
                    {

                    }
                }
            }
        }

        private static void SeedRoles(RoleManager<AppRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Admin";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }

            if (!roleManager.RoleExistsAsync("Cashier").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Cashier";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }
            if (!roleManager.RoleExistsAsync("Accounting").Result)
            {
                AppRole role = new AppRole();
                role.Name = "Accounting";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }
            if (!roleManager.RoleExistsAsync("MobileSales").Result)
            {
                AppRole role = new AppRole();
                role.Name = "MobileSales";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }
            if (!roleManager.RoleExistsAsync("StockRoom").Result)
            {
                AppRole role = new AppRole();
                role.Name = "StockRoom";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }
            if (!roleManager.RoleExistsAsync("TechnicalService").Result)
            {
                AppRole role = new AppRole();
                role.Name = "TechnicalService";
                var roleResult = roleManager.CreateAsync(role).Result;
                if (roleResult.Succeeded)
                {

                }

            }
        }

    }
}
