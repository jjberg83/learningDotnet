namespace Intermediate.Interfaces;
public class OrderProcessor
{
    // De to første bolkene her har en dependency til den konkrete klassen ShippingCalculator, som ikke er bra

    // private readonly ShippingCalculator _shippingCalculator;

    // public OrderProcessor()
    // {
    //     _shippingCalculator = new ShippingCalculator(); // Her instansierer man ShippingCalculator (det man mener med konkret)
    // }

    // Bedre å gjøre denne klassen avhengig av et interface i stedet (high level policy)
    private readonly IShippingCalculator _shippingCalculator;

    public OrderProcessor(IShippingCalculator shippingCalculator)
    {
        _shippingCalculator = shippingCalculator;
    }
    public void Process(Order order)
    {
        if (order.IsShipped)
            throw new InvalidOperationException("The order is already processed");

        order.Shipment = new Shipment
        {
            Cost = _shippingCalculator.CalculateShipping(order),
            ShippingDate = DateTime.Today.AddDays(1)
        };
    }
}
