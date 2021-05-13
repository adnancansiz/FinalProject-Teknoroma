using BLL.Repositories.Abstract;
using BLL.Repositories.Concrete;
using DAL.Context;
using DAL.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer("Server=.;Database=Teknoroma; Trusted_Connection=True;"));

            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequiredLength = 5;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISubCategoryService, SubCategoryService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IIssueService, IssueService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IEmployeePaymentService, EmployeePaymentService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                 pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");

            });
            
        }
    }
}
