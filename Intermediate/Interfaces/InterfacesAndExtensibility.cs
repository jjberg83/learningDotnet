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
        dbMigratorConsoleVersion.Migrate();
        dbMigratorConsoleVersion.ShowError();

        // Nå kjører vi akkurat samme kode. 
        // Eneste forskjellen er at vi legger inn en FileLogger implementasjon
        // i stedet for en ConsoleLogger implementasjon som argument i konstruktøren til DbMigrator
        // ConsoleLogger krever jo også en path som argument, så det er også forskjellig
        dbMigratorConsoleVersion = new DbMigrator(new FileLogger("/Users/jjberg/Github/learningDotnet/Intermediate/Interfaces/LogFile.txt"));
        dbMigratorConsoleVersion.Migrate();
        dbMigratorConsoleVersion.ShowError();

        // Vi har altså ikke endret noe kode i DbMigrator klassen.
        // Den oppfører seg forskjellig alt etter hvilke implemetasjoner vi legger inn som argument
        // Altså alt etter hvilke implementasjoner av ILogger vi legger inn
        // Vil vi at den skal oppføre seg forskjellig, legger vi til en ny klasse som gjør noe ingen andre klasser har gjort til nå
        // (så lenge den nye klassen oppfyller ILogger sine krav)
        // Dette er essenssen av OpenClosed Principle
        // Software entities should be open for extension, but closed for modification
    }
}