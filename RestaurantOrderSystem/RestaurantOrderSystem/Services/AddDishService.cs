using RestaurantOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Services
{
    public class AddDishService
    {
        public void AddDish(List<Dish> menu,Dish dish) => menu.Add(dish);
    }
}
