
using BLL.ViewModels.ApiVM;
using BLL.ViewModels.ReportsVM;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<ProductVM> GetAllProductForApi();

        List<Top10ProductVM> GetTop10();

    }
}
