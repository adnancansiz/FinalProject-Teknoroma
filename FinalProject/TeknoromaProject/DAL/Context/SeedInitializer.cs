using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Context
{
    public static class SeedInitializer
    {
        public static void SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, ApplicationDbContext context)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
            SeedUse(context);
        }

        private static void SeedUsers(UserManager<AppUser> userManager)
        {
            if (userManager.FindByNameAsync("Admin").Result == null)
            {
                AppUser Admin = new AppUser();
                Admin.UserName = "Admin";
                Admin.Email = "admin@admin.com";
                Admin.FirstName = "Admin";
                Admin.LastName = "Admin";
                Admin.Status = DAL.Entities.Enum.Status.Active;
                Admin.CreatedBy = "Test";
                Admin.CreatedComputerName = "Test";
                Admin.CreatedDate = DateTime.Now;
                Admin.CreatedIP = "^Test";

                AppUser Cashier = new AppUser();
                Cashier.UserName = "Cashier";
                Cashier.Email = "Cashier@Cashier.com";
                Cashier.FirstName = "Cashier";
                Cashier.LastName = "Cashier";
                Cashier.Status = DAL.Entities.Enum.Status.Active;
                Cashier.CreatedBy = "Test";
                Cashier.CreatedComputerName = "Test";
                Cashier.CreatedDate = DateTime.Now;
                Cashier.CreatedIP = "^Test";

                AppUser Accounting = new AppUser();
                Accounting.UserName = "Accounting";
                Accounting.Email = "Accounting@Accounting.com";
                Accounting.FirstName = "Accounting";
                Accounting.LastName = "Accounting";
                Accounting.Status = DAL.Entities.Enum.Status.Active;
                Accounting.CreatedBy = "Test";
                Accounting.CreatedComputerName = "Test";
                Accounting.CreatedDate = DateTime.Now;
                Accounting.CreatedIP = "^Test";

                AppUser MobileSales = new AppUser();
                MobileSales.UserName = "MobileSales";
                MobileSales.Email = "MobileSales@MobileSales.com";
                MobileSales.FirstName = "MobileSales";
                MobileSales.LastName = "MobileSales";
                MobileSales.Status = DAL.Entities.Enum.Status.Active;
                MobileSales.CreatedBy = "Test";
                MobileSales.CreatedComputerName = "Test";
                MobileSales.CreatedDate = DateTime.Now;
                MobileSales.CreatedIP = "^Test";

                AppUser StockRoom = new AppUser();
                StockRoom.UserName = "StockRoom";
                StockRoom.Email = "StockRoom@StockRoom.com";
                StockRoom.FirstName = "StockRoom";
                StockRoom.LastName = "StockRoom";
                StockRoom.Status = DAL.Entities.Enum.Status.Active;
                StockRoom.CreatedBy = "Test";
                StockRoom.CreatedComputerName = "Test";
                StockRoom.CreatedDate = DateTime.Now;
                StockRoom.CreatedIP = "^Test";

                AppUser TechnicalService = new AppUser();
                TechnicalService.UserName = "TechnicalService";
                TechnicalService.Email = "TechnicalService@TechnicalService.com";
                TechnicalService.FirstName = "TechnicalService";
                TechnicalService.LastName = "TechnicalService";
                TechnicalService.Status = DAL.Entities.Enum.Status.Active;
                TechnicalService.CreatedBy = "Test";
                TechnicalService.CreatedComputerName = "Test";
                TechnicalService.CreatedDate = DateTime.Now;
                TechnicalService.CreatedIP = "^Test";


                var resultAdmin = userManager.CreateAsync(Admin, "Test123++").Result;
                if (resultAdmin.Succeeded)
                {
                    userManager.AddToRoleAsync(Admin, "Admin").Wait();
                }
                else
                {
                    foreach (var item in resultAdmin.Errors)
                    {

                    }
                }

                var resultKasiyer = userManager.CreateAsync(Cashier, "Test123++").Result;
                if (resultKasiyer.Succeeded)
                {
                    userManager.AddToRoleAsync(Cashier, "Cashier").Wait();
                }
                else
                {
                    foreach (var item in resultKasiyer.Errors)
                    {

                    }
                }

                var resultAccounting = userManager.CreateAsync(Accounting, "Test123++").Result;
                if (resultAccounting.Succeeded)
                {
                    userManager.AddToRoleAsync(Accounting, "Accounting").Wait();
                }
                else
                {
                    foreach (var item in resultAccounting.Errors)
                    {

                    }
                }

                var resultMobileSales = userManager.CreateAsync(MobileSales, "Test123++").Result;
                if (resultMobileSales.Succeeded)
                {
                    userManager.AddToRoleAsync(MobileSales, "MobileSales").Wait();
                }
                else
                {
                    foreach (var item in resultMobileSales.Errors)
                    {

                    }
                }

                var resultStockRoom = userManager.CreateAsync(StockRoom, "Test123++").Result;
                if (resultStockRoom.Succeeded)
                {
                    userManager.AddToRoleAsync(StockRoom, "StockRoom").Wait();
                }
                else
                {
                    foreach (var item in resultStockRoom.Errors)
                    {

                    }
                }

                var resultTechnicalService = userManager.CreateAsync(TechnicalService, "Test123++").Result;
                if (resultTechnicalService.Succeeded)
                {
                    userManager.AddToRoleAsync(TechnicalService, "TechnicalService").Wait();
                }
                else
                {
                    foreach (var item in resultTechnicalService.Errors)
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


        private static void SeedUse(ApplicationDbContext context)
        {
            if (context.Categories.Count() == 0)
            {
                Category category = new Category();
                category.CategoryName = "Elektronik";
                category.Description = "Elektronik Eşyalar";
                category.Id = new Guid();
                context.Categories.Add(category);

                Category category1 = new Category();
                category1.CategoryName = "Beyaz Eşya";
                category1.Description = "Beyaz Eşyalar";
                category1.Id = new Guid();
                context.Categories.Add(category1);

                SubCategory subCategory = new SubCategory();
                subCategory.Id = new Guid();
                subCategory.SubCategoryName = "Telefon";
                subCategory.Description = "Akıllı Telefonlar";
                subCategory.CategoryId = category.Id;
                context.SubCategories.Add(subCategory);

                SubCategory subCategory1 = new SubCategory();
                subCategory1.Id = new Guid();
                subCategory1.SubCategoryName = "Buzdolabı";
                subCategory1.Description = "Buzdolabı";
                subCategory1.CategoryId = category1.Id;
                context.SubCategories.Add(subCategory1);

                Customer customer = new Customer();
                customer.Id = new Guid();
                customer.CustomerName = "Ahmet Çalışkan";
                customer.Gender = DAL.Entities.Enum.Gender.Male;
                customer.EmailAddress = "ahmet.caliskan@app.com";
                customer.Phone = "0530888999666";
                customer.Address = "İstanbul/Kadıköy";
                customer.BirthDate = DateTime.Now;
                customer.TC = "11122233365";
                context.Customers.Add(customer);

                Customer customer1 = new Customer();
                customer1.Id = new Guid();
                customer1.CustomerName = "Serpil Ak";
                customer1.Gender = DAL.Entities.Enum.Gender.Female;
                customer1.EmailAddress = "serpil.ak@app.com";
                customer1.Phone = "0530777744485";
                customer1.Address = "İstanbul/Kartal";
                customer1.BirthDate = DateTime.Now;
                customer1.TC = "77788596652";
                context.Customers.Add(customer1);

                Supplier supplier = new Supplier();
                supplier.Id = new Guid();
                supplier.PhoneNumber = "053099988563";
                supplier.CompanyName = "Apple";
                supplier.ContactName = "Merve Yalçın";
                supplier.Email = "apple.tedarik@apple.com";
                context.Suppliers.Add(supplier);

                Supplier supplier1 = new Supplier();
                supplier1.Id = new Guid();
                supplier1.PhoneNumber = "05306975136";
                supplier1.CompanyName = "Arçelik";
                supplier1.ContactName = "Hakan Türk";
                supplier1.Email = "arcelik.tedarik@arcelik.com";
                context.Suppliers.Add(supplier1);

                Product product = new Product();
                product.BarcodeNumber = "87984919126";
                product.Id = new Guid();
                product.SubCategoryId = subCategory.Id;
                product.ProductName = "İphone 11 Red";
                product.SupplierId = supplier.Id;
                product.UnitPrice = 7999;
                product.UnıtsInStock = 100;
                context.Products.Add(product);

                Product product1 = new Product();
                product1.BarcodeNumber = "8792452452126";
                product1.Id = new Guid();
                product1.SubCategoryId = subCategory.Id;
                product1.ProductName = "İphone 11 Black";             
                product1.SupplierId = supplier.Id;
                product1.UnitPrice = 7999;
                product1.UnıtsInStock = 100;
                context.Products.Add(product1);

                Product product2 = new Product();
                product2.BarcodeNumber = "87978645247126";
                product2.Id = new Guid();
                product2.SubCategoryId = subCategory.Id;
                product2.ProductName = "İphone 11 Purple";               
                product2.SupplierId = supplier.Id;
                product2.UnitPrice = 7999;
                product2.UnıtsInStock = 100;
                context.Products.Add(product2);

                Product product3 = new Product();
                product3.BarcodeNumber = "87984918484647";
                product3.Id = new Guid();
                product3.SubCategoryId = subCategory1.Id;
                product3.ProductName = "Arçelik A+ 490LT Buzdolabı";                
                product3.SupplierId = supplier1.Id;
                product3.UnitPrice = 4999;
                product3.UnıtsInStock = 100;
                context.Products.Add(product3);

                Product product4 = new Product();
                product4.BarcodeNumber = "87956153111247";
                product4.Id = new Guid();
                product4.SubCategoryId = subCategory1.Id;
                product4.ProductName = "Arçelik A+ 520LT Buzdolabı";
                product4.SupplierId = supplier1.Id;
                product4.UnitPrice = 4999;
                product4.UnıtsInStock = 100;
                context.Products.Add(product4);


                SupplierExpense expense1 = new SupplierExpense();
                expense1.Id = new Guid();
                expense1.ProductId = product.Id;
                expense1.Price = 6999;
                expense1.Quantity = 100;
                context.SupplierExpenses.Add(expense1);

                SupplierExpense expense2 = new SupplierExpense();
                expense2.Id = new Guid();
                expense2.ProductId = product1.Id;
                expense2.Price = 6999;
                expense2.Quantity = 100;
                context.SupplierExpenses.Add(expense2);

                SupplierExpense expense3 = new SupplierExpense();
                expense3.Id = new Guid();
                expense3.ProductId = product2.Id;
                expense3.Price = 6999;
                expense3.Quantity = 100;
                context.SupplierExpenses.Add(expense3);

                SupplierExpense expense4 = new SupplierExpense();
                expense4.Id = new Guid();
                expense4.ProductId = product3.Id;
                expense4.Price = 3999;
                expense4.Quantity = 100;
                context.SupplierExpenses.Add(expense4);

                SupplierExpense expense5 = new SupplierExpense();
                expense5.Id = new Guid();
                expense5.ProductId = product4.Id;
                expense5.Price = 3999;
                expense5.Quantity = 100;
                context.SupplierExpenses.Add(expense5);


                context.SaveChanges();
            }



        }
    }
}
