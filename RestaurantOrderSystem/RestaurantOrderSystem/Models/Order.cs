using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Models;

public class Order
{

    public int Id { get; set; }
    public List<Dish>? Dishes { get; set; }
    public double TotalAmount { get; set; }

    public Order(int id, List<Dish> dishes, double totalAmount)
    {
        Id = id;
        Dishes = dishes;
        TotalAmount = totalAmount;
    }


}
