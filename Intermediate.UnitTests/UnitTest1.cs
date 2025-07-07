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

        // (Om det under. Det viktigste er at når klassen er avhengig av et interface eller abstract
        // klasse, skaper man en falsk klasse av det. Da inneholder den business logic. Er den avhengig
        // av enkle data klasser som kun inneholder data og simple metoder, trenger man ikke skape
        // falske klasser.)
        // Vi lager ikke falske klasser av Order eller Shipment, fordi OrderProcessor ikke er 
        // avhengig av disse. I OrderProcessor injiseres IShippingCalculator som et argument
        // inn i konstruktøren, altså er det en dependency. Order og Shipment klassene brukes
        // bare som argument (eller skapes) i metodene til OrderProcessor, og er derfor ikke
        // dependencies til hele klassen som helhet. Det finnes unntak der man likevel kan skape falske
        // klasser, selv om de ikke er dependencies, og det er når de er veldig komplekse eller har
        // sideeffekter og gjerne er eksterne. Jeg kan se for meg en tredjeparts betalingsløsning for eksempel (Stripe).
        // NB: Vi instansierer Shipment, slik at den ikke er null. Fieldet IsShipped er altså true da.
        //  ( jeg har også lært senere at grunnen til at man ikke lager
        // interfaces av disse, men at man bruker rene klasser inni andre klasser, er fordi de er såkalte
        // data classes, altså klasser somh hovedsaeklig inneholder data (men kan inneholde veldig simple
        // metoder. Er de derimot klasser med BEHAVIOUR, altså inneholder metoder med komplisert business logic
        // må vi bruke interfaces i stedet.) Gjerne det også har noe å si for om man må skape falske klasser,
        // alt etter av om de er interfaces eller ikke?). 
        var order = new Order
        {
            Shipment = new Shipment()
        };

        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
    }

    [Fact]
    public void Process_OrderIsNotShipped_CreatesNewShipment()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order(); // Shipment blir altså null
        orderProcessor.Process(order);
        Assert.True(order.IsShipped);
        Assert.Equal(1, order.Shipment.Cost);
        Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
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