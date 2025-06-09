using Intermediate.Interfaces;
using Xunit;

namespace Intermediate.UnitTests;

public class OrderProcessorTests
{
    // I unit tests tester man bare funksjonalitet for klassen man er i. 
    // Default navnestruktur er: Metode(man tester)_ Condition_ForventetOutput
    [Fact]
    public void Process_OrderIsAlreadyShipped_ThrowsInvalidOperationException()
    {
        var orderProcessor = new OrderProcessor();
        LKSJF lkøj = new LKSJF();
    }
}
