using RestaurantOrderSystem.Models;
namespace RestaurantOrderSystem;


//public static class DishExtensions
//{
//    public static decimal Sum(this List<Dish> dishes)
//    {
//        return dishes.Sum(dish => dish.Price);
//    }
//}




internal class Program
{
  

    static void Main(string[] args)
    {



    }

    public static List<Dish> FindDishesByCategory(List<Dish> dishes, Category category)
    {
        return dishes.Where(dish => dish.Category == category).ToList();
    }

    //public void PlaceOrder(Order order)
    //{
    //    Orders.Add(order);
    //}

    //public Order FindOrderById(int orderId)
    //{
    //    return Orders.FirstOrDefault(order => order.Id == orderId);
    //}

    //public void AddDish(Dish dish)
    //{
    //    Menu.Add(dish);
    //}



}