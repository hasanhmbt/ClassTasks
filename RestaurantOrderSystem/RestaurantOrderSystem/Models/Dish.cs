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
    public double Price { get; set; }
    public Category Category { get; set; }

    public Dish(int id, string name,double price,Category category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;

    }


    public Dish()
    {
            
    }

}
