namespace Intermediate.Interfaces;
public class InterfacesAndTestability
{
    public static void Run()
    {
        var orderProcessor = new OrderProcessor();
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);
    }
}