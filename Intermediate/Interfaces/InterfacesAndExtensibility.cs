namespace Intermediate.Interfaces;
public class InterfacesAndExtensibility
{
    public static void Run()
    {
        // Koden under gikk ved første versjon av DbMigrator
        // var dbMigrator = new DbMigrator();

        // Nå går det ikke lenger, fordi vi må legge inn en implementasjon av interfacet
        // i argumentet, siden konstruktøren i klassen krever det. Her har man altså
        // ingen ekstern fil som sjekker noe. Vi ser det i selve instansieringen av
        // klassen hvilken implementasjon som skal brukes. Vi må opprettte disse
        // forskjellige implementasjonene i egne filer, og alle må oppfylle ILogger interfacet
        // for å kunne brukes som argument her. 

        var dbMigratorConsoleVersion = new DbMigrator(new ConsoleLogger());
        dbMigratorConsoleVersion.LogInfo("Det virker i det minste, men er det rett måte å gjøre det på?");
        Console.WriteLine("------------------------");
        dbMigratorConsoleVersion.LogError("FUBAR");
    }
}