using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderSystem.Models;

internal class Restaurant
{

    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }



    public Restaurant(    )
    {
        
    }

}
