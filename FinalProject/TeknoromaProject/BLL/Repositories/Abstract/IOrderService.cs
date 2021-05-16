using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        Order AddOrderDetailInOrder(OrderDetail orderDetail);

        bool CreateOrder(Order order);
    }
}
