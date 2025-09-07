using System.Threading.Tasks;

namespace Advanced.Async;

// I asynchronous programming fortsetter flowen i programmet uten å vente på at 
// metoder blir ferdige. Typiske eksempler er når man skal nå noe på nett, hente
// noe fra en database eller jobbe med bilder. Med asynchronous applikasjoner
// fryser ikke disse når tunge operasjoner er i gang. Interfacet reagerer fortsatt.
// Mosh kaller slike operasjoner for "blocking operations".

// Alle async metoder returnerer en task, som forteller om tilstanden til vår 
// async prosess. Task brukes for void metoder, de som returner noe bruker
// Task<dataType>. Norm at async metoder slutter på Async. Som i metodeNavnAsync.

// De fleste metoder i C# har egne Async varianter. Da bruker man de og putter 
// await foran. Det er gjerne ikke så intuitivt, men det betyr at programmet 
// IKKE skal vente, men bare gå videre. Når metoden er ferdig, gir den beskjed
// til runtime, som tar fokuset tilbake til der flowen stoppet før den gikk videre. 
// Hver gang man bruker await inni en metode, må metoden man bruker det i, være async.

// Simuler eksempel med metode som bruker lang tid med at jeg har en sleep. 
// Han brukte WPF app i Visual Studio, altså Windows Presentation Foundation.
// Først viser han at med vanlig void metode, fryser appliaksjonen. Så viser han
// at applikasjonen fortsatt reagerer med async void metode.

// Deretter viser han det samme, bare med metode som faktisk returner noe.

public class Async
{
    public static async Task Run()
    {
        Console.WriteLine("---------------------");
        // TimeConsumingMethod(); // Eksempel på vanlig metode, der vi må vente på at den skal fullføre, før programmet går videre til neste linje
        var task = TimeEffectiveMethodAsync(); // Eksempel på async metode, som ikke stoppe flowen
        Console.WriteLine("Program avsluttes!"); // Med async kommer dette før console.writelinene inni metoden. Man trenger altså ikke vente. Her kan man for eksempel også legge inn arbeid man vil skal gjøres mens den tunge jobben gjøres.
        await task;
    }

    private async static Task TimeEffectiveMethodAsync()
    {
        Console.WriteLine("Metode har startet...");
        await Task.Delay(5000);
        Console.WriteLine("Stadie 1 fullført");
        await Task.Delay(5000);
        Console.WriteLine("Stadie 2 fullført");
        await Task.Delay(5000);
        Console.WriteLine("Stadie 3 fullført. Hele prosessen i boks!");
    }

    private static void TimeConsumingMethod()
    {
        Console.WriteLine("Metode har startet...");
        Thread.Sleep(5000);
        Console.WriteLine("Stadie 1 fullført");
        Thread.Sleep(5000);
        Console.WriteLine("Stadie 2 fullført");
        Thread.Sleep(5000);
        Console.WriteLine("Stadie 3 fullført. Hele prosessen i boks!");
    }
}