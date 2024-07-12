namespace RestaurantOrderSystem.Models;

internal class Restaurant
{

    public string Name { get; set; }
    public string? Address { get; set; }
    public List<Dish> Menu { get; set; }
    public List<Order> Orders { get; set; }



    public Restaurant(string name)
    {
        Name = name;
        Menu = new List<Dish>();
        Orders = new List<Order>();
    }


    public Order? FindOrderById(int orderId) => Orders.Find(order => order.Id == orderId);
    public void AddDish(Dish dish) => Menu.Add(dish);
    public void PlaceOrder(Order order) => Orders.Add(order);


}
