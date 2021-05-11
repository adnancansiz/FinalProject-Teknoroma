using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface ICustomerService:IGenericService<Customer>
    {
        Customer FindByTC(string TC);
    }
}
