﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Models;

public class Category
{


    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Dish>? Dishes { get; set; }

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
        Dishes = new List<Dish>();
    }


}
