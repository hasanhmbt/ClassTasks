using RestaurantOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Services
{
    public class FindDishesByCategoryService
    {
        public static List<Dish> FindDishesByCategory(List<Dish> dishes, Category category) =>
            dishes.Where(dish => dish.Category.Id == category.Id).ToList();

    }
}
