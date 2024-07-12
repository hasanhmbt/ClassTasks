using RestaurantOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem;

public static class Extentions
{
    public static decimal CalculateTotalPrice(this List<Dish> dishes) => (decimal)dishes.Sum(dish => dish.Price);
     
}


 
