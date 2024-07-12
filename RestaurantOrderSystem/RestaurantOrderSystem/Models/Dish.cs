using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Models;

public class Dish
{


    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category? Category { get; set; }

    public Dish(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;

    }


    public static List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {
        return dishes.Where(dish => dish.Category.Id == category.Id).ToList();
    }

}
