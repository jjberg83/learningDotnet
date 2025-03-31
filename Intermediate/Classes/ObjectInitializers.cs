namespace Intermediate.Classes;
public class ObjectInitializers
{
    public static void Run()
    {
        // I stedet for å ha 100 000 constructorer for hver type scenario, kan man bruke
        // object initializers. Her skal vi bruke Invoice klassen, og spesifisere de feltene
        // vi ønsker (vi har kun én constructor der, som tar seg av det ene fieldset som 
        // er en liste).

        var order1 = new Order();
        var order2 = new Order();
        var order3 = new Order();

        // Her initialiserer vi en instans der vi retter oss mot bare 2 av fieldsene i initialiseringen
        var invoice1 = new Invoice 
            {
                Id = 1,
                Amount = 100.5f                
            };
        invoice1.Orders.Add(order3);
        invoice1.Orders.Add(order1);
        
        // Her initialiserer vi en instans der vi retter oss mot alle fieldsene i initialiseringen
        var invoice2 = new Invoice 
            {
                Currency = "NOK",
                Id = 2,
                Amount = 315.5f                
            };
        invoice1.Orders.Add(order1);
        invoice1.Orders.Add(order2);
    }
}