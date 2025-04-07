namespace Intermediate.Classes;

public class Customer
{
    public int Id;
    public string? Name;

    // readonly gjør at listen kun kan initialiseres en gang, nemlig her eller i constructoren
    readonly public List<Order> Orders = new(); // Listen kan initialiseres herfra også. Spesielt siden den ikke får parametere fra utsiden.

    // lager nye blanke constructors med shortcuten "ctor" (code snippet)
    public Customer()
    {
        //Orders = new List<Order>(); // alltid intialiser fields som er lister
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

    public void Promote()
    {
        // Orders = new List<Order>();
    }
}
