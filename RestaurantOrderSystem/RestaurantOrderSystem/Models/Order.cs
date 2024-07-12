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
   // public decimal TotalAmount { get { return Dishes.CalculateTotalPrice(); } }
    public decimal TotalAmount  => Dishes.CalculateTotalPrice(); 
    public Order(int id)
    {
        Id = id;
        Dishes = new List<Dish>();
    }

     

}
