using RestaurantOrderSystem.Models;
using System.Xml.Linq;

namespace RestaurantOrderSystem;


public static class DishExtensions
{
    public static decimal CalculateTotalPrice(this List<Dish> dishes)
    {
        return (decimal)dishes.Sum(dish => dish.Price);
    }
}


internal class Program
{

    static void Main(string[] args)
    {


    }

    

     

     


}