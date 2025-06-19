using Intermediate.Interfaces;
using Xunit;

namespace Intermediate.UnitTests;

public class OrderProcessorTests
{
    // I unit tests tester man bare funksjonalitet for klassen man er i. 
    // Default navnestruktur er: Metode(man tester)_ Condition_ForventetOutput
    // [Fact] markerer at metoden er en test. I tillegg har man en Assert, som 
    // er fasiten man vil frem til. Hvis testen ikke har outputtet inni <> i Assert,
    // feiler testen.
    [Fact]
    public void Process_OrderIsAlreadyShipped_ThrowsInvalidOperationException()
    {
        // I argumentetet under må vi lage en falsk ShippingCalculator
        // Grunnen til at vi ikke vil bruke den originale er fordi vi ikke
        // ønsker å være avhengig av den i testen. Derfor lager vi en lokal klone her
        // som vi setter i en perfekt tilstand. Her tester vi OrderProcessor metoden Process,
        // og antar derfor at alt annet er perfekt. Derfor lager vi en klone som alltid er 
        // i en perfekt tilstand.
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

        // Skjønner ikke helt hvorfor vi også ikke lager en fake Order klasse
        // av samme grunn som over?
        // NB: Vi instansierer Shipment, slik at den ikke er null. Fieldet IsShipped er altså true da.
        var order = new Order
        {
            Shipment = new Shipment()
        };

        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        // Bruker ikke original logikk. Det er ikke det vi bryr oss om å teste.
        // Vi returnerer bare et tall.
        return 1;

        // Original kode
        // if (order.TotalPrice < 30f)
        //     return order.TotalPrice * 0.1f;

        // return 0;
    }
}