using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem.Order
{
    internal interface IOrderRepository
    {
        bool Create(OrderModel order);
        List<OrderModel> GetAll();
        List<OrderModel> GetOrdersByCustomerId(int customerId);
    }
}
