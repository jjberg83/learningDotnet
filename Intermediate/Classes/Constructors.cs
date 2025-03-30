namespace Intermediate.Classes;
public class Constructors
{
    public static void Run()
    {
        var me = new Customer(); // Tester man nå ser man at fieldsene får default verdier
        var order = new Order();
        me.Orders.Add(order); // krasjer hvis jeg ikke har initialisert listen kalt Orders i Customer klassen 

        var you = new Customer(6);
        var him = new Customer(7, "Arnold");
    }
}