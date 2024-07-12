using RestaurantOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Services
{
    public class PlaceOrderService
    {
        public void PlaceOrder(List<Order> orders,Order order) => orders.Add(order);

    }
}
