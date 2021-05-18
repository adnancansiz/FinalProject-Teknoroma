using BLL.ViewModels.ReportsVM;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface ISupplierExpenseService : IGenericService<SupplierExpense>
    {
        List<SupplierExpenseReportVM> GetMountlyReport();
        List<SupplierExpenseReportVM> GetAllTimeReport();
    }
}
