using RestaurantOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Services
{
    public class FindOrderByIdService
    {
        public Order? FindOrderById(List<Order> orders, int orderId) => orders.SingleOrDefault(order => order.Id == orderId);

    }
}
