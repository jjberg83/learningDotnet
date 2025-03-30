namespace Intermediate.Classes;

public class Customer
{
    public int Id;
    public string? Name;

    public List<Order> Orders;

    // lager nye blanke constructors med shortcuten "ctor" (code snippet)
    public Customer()
    {
        Orders = new List<Order>(); // alltid intialiser fields som er lister
    }
    public Customer(int id)
        : this() // betyr = kjør først constructoren som ikke tar noen parametere i parentesen, her initialiserer man listen
    {
        this.Id = id;
    }

    public Customer(int id, string name)
        : this(id) // betyr = kjør først constructoren som tar id som paramter
    {
        this.Name = name;
    }
}
