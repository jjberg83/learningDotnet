namespace Intermediate.Interfaces;
public class InterfacesAndTestability
{
    public static void Run()
    {
        // I argumentet under krever klassen en implementasjon av interfacet IShippingCalculator. Det blir jo altså konkret.
        // Men det er greit i main klassen (dette er jo ikke main, men det simulerer main).
        // Main vet om andre konkrete klasser, og avhengigheter inni main er OK. Men OrderProcessor aner ingenting om
        // ShippingCalculator klassen. Den er bare avhengig til IShippingCalculator (interfacet)
        var orderProcessor = new OrderProcessor(new ShippingCalculator());
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);
    }
}