namespace Intermediate.Classes;

public class Fields
{
    public static void Run()
    {
        var jørund = new Customer();
        var order1 = new Order();
        var order2 = new Order();
        var order3 = new Order();
        jørund.Orders.Add(order1);
        jørund.Promote();
        jørund.Orders.Add(order2);
        jørund.Orders.Add(order3);
        // Kjører man koden over i debug mode ser man at Orders listen kun inneholder 2 ordre
        // fordi Promote metoden lager en ny liste. Med readonly foran Orders fieldet i 
        // Customer klassen, får ikke Promote metoden lov til dette.
    }
}