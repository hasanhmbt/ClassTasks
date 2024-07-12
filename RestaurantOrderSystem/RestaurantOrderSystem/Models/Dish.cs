using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Models;

public class Dish:BaseEntites
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category? Category { get; set; }

    public Dish(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

}
