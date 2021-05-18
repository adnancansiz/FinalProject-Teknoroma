using BLL.Repositories.Abstract;
using BLL.ViewModels.ReportsVM;
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
    public class SupplierExpenseService : ISupplierExpenseService
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IProductService _productService;

        public SupplierExpenseService(ApplicationDbContext context, SignInManager<AppUser> signInManager, IProductService productService)
        {
            _context = context;
            _signInManager = signInManager;
            _productService = productService;
        }

        public void Create(SupplierExpense entity)
        {
            try
            {
                entity.Id = Guid.NewGuid();
                entity.CreatedBy = _signInManager.Context.User.Identity.Name;
                entity.CreatedComputerName = Environment.MachineName;
                entity.CreatedDate = DateTime.Now;
                entity.CreatedIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString();

                _context.SupplierExpenses.Add(entity);
                _context.SaveChanges();

                var product = _productService.GetById(entity.ProductId);
                product.UnıtsInStock += entity.Quantity;
                _productService.Update(product);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }

        }

        public void Delete(SupplierExpense entity)
        {
            entity.Status = DAL.Entities.Enum.Status.Deleted;
            Update(entity);
        }

        public List<SupplierExpense> GetActive()
        {
            return _context.SupplierExpenses.Where(x => x.Status == DAL.Entities.Enum.Status.Active || x.Status == DAL.Entities.Enum.Status.Updated).ToList();

        }

        public List<SupplierExpenseReportVM> GetAllTimeReport()
        {
            List<SupplierExpenseReportVM> vM = new List<SupplierExpenseReportVM>();

            var query = from se in _context.SupplierExpenses
                        join p in _context.Products on se.ProductId equals p.Id
                        join s in _context.Suppliers on p.SupplierId equals s.Id
                        select new SupplierExpenseReportVM
                        {
                            ID = se.Id,
                            SupplierId = s.Id,
                            SupplierName = s.CompanyName,
                            ProductId = p.Id,
                            ProductName = p.ProductName,
                            CreatedDate = se.CreatedDate,
                            Total = se.Quantity
                        };

            foreach (SupplierExpenseReportVM se in query)
            {
                bool exist = false;

                foreach (SupplierExpenseReportVM v in vM)
                {
                    if (se.ProductId == v.ProductId)
                    {
                        exist = true;
                        v.Total += se.Total;
                        break;
                    }
                }
                if (!exist)
                {
                    vM.Add(new SupplierExpenseReportVM
                    {
                        ID = se.ID,
                        CreatedDate = se.CreatedDate,
                        ProductName = se.ProductName,
                        SupplierName = se.SupplierName,
                        ProductId = se.ProductId,
                        SupplierId = se.SupplierId,
                        Total = se.Total

                    });
                }
            }

            return vM;
        }

        public List<SupplierExpense> GetByDefault(Expression<Func<SupplierExpense, bool>> filter = null)
        {
            if (filter != null)
            {
                return _context.SupplierExpenses.Where(filter).ToList();
            }
            else
            {
                return _context.SupplierExpenses.ToList();
            }
        }

        public SupplierExpense GetById(Guid id)
        {
            var supplierExpense = _context.SupplierExpenses.FirstOrDefault(x => x.Id == id);
            return supplierExpense;
        }

        public List<SupplierExpenseReportVM> GetMountlyReport()
        {
            List<SupplierExpenseReportVM> vM = new List<SupplierExpenseReportVM>();

            var query = from se in _context.SupplierExpenses
                        join p in _context.Products on se.ProductId equals p.Id
                        join s in _context.Suppliers on p.SupplierId equals s.Id
                        select new SupplierExpenseReportVM
                        {
                            ID = se.Id,
                            SupplierId = s.Id,
                            SupplierName = s.CompanyName,
                            ProductId = p.Id,
                            ProductName = p.ProductName,
                            CreatedDate = se.CreatedDate,
                            Total = se.Quantity
                        };

            foreach (SupplierExpenseReportVM se in query)
            {
                bool exist = false;
                var seM = se.CreatedDate.Month;
                var seY = se.CreatedDate.Year;

                var dayY = DateTime.Now.Year;
                var dayM = DateTime.Now.Month;

                foreach (SupplierExpenseReportVM v in vM)
                {

                    if (se.ProductId == v.ProductId)
                    {
                        if (seM == dayM && seY == dayY)
                        {
                            exist = true;
                            v.Total += se.Total;
                            break;
                        }

                    }
                }
                if (!exist)
                {
                    if (seM == dayM && seY == dayY)
                    {
                        vM.Add(new SupplierExpenseReportVM
                        {
                            ID = se.ID,
                            CreatedDate = se.CreatedDate,
                            ProductName = se.ProductName,
                            SupplierName = se.SupplierName,
                            ProductId = se.ProductId,
                            SupplierId = se.SupplierId,
                            Total = se.Total

                        });
                    }

                }
            }

            return vM;

        }

        public void Update(SupplierExpense entity)
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

            _context.SupplierExpenses.Update(entity);
            _context.SaveChanges();
        }
    }
}
