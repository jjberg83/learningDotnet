
using Fundamentals.ClassToBeUsedFromAnotherAssembly;

namespace Intermediate.Inheritance;
public class AccessModifiers
{
    public static void Run()
    {
        // Snakker om hvorfor vi bruker encapsulation (lar klassene være som black boxes)
        // Det har ingenting med sikkerhet å gjøre, som jeg trodde var en del av grunnen
        // Grunnen er enkelt og greit at ved å gjøre klasser "vanskelige" å bruke, 
        // reduserer man avhengighetene til de. Hvis det er få avhengigheter, er effektene
        // av å endre en klasse så lav som mulig. Kun det som absolutt må brukes fra utsiden,
        // sendes ut. Se for deg en DVD spiller. Alt vi trykker på er et par knapper. Vi driter
        // i hvordan den ser ut fra innsiden. Vi er kun avhengige av knappene. Filmopplevelsen
        // spoleres ikke av en software oppdatering på dvd spilleren. Fordi vi aldri gjorde oss
        // avhengig av noe inni dvd spilleren. Vi er kun avhengig av knappene.

        // Vi har følgende access modifiers (kan fint bruke det på metoder også):
        // public
        // private
        // protected (samme som private, men derived classes (ikke instanser men child klasser) kan også nå protected field/metode). Unngå om mulig, reduserer encapsulation.
        // internal (tilgjenglig kun for klasser i samme assembly, og brukes på klassen, ikke dens fields og methods)
        // protected internal (tilgjengelig kun for klasser i samme assembly, eller derived/child klasser, hold deg unna)

        IntermediateCustomer stian = new IntermediateCustomer();
        stian.Promote();
        // CalculateRating er ikke synlig pga private, og klassen vi er i nå rekker ikke å bli avhengig av den
        // stian.CalculateRating();
        GoldCustomer marit = new GoldCustomer();
        Console.WriteLine(marit.OfferVoucher()); 

        // Her bruker vi Customer klassen, men fra Fundamentals assembliet
        // Søk etter Add Project Reference
        // Eller med TErminal:
        // cd <directory jeg vil hente noe inn til>
        // dotnet add reference "dotnet add reference ../Fundamentals/Fundamentals.csproj"
        // skal nå kunne se referansen i .csproj filen
        // dotnet build

        // Siden jeg nå har en referanse til Fundamentals prosjektet/assmbliet i
        // Intermediate.csproj, kan jeg bruke en using øverst for å nå klassen under
        // Men legger jeg inn en "internal" i FundamentalCustomer klassen, kan den 
        // kun nås fra klasser inni Fundamentals assembliet (du kan se at den nåes fra TryOutCustomerClass.cs i Fundamentals)
        // FundamentalCustomer benjamin = new FundamentalCustomer();
    }
}
