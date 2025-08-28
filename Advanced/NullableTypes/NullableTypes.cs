namespace Advanced.NullableTypes;

public class NullableTypes
{
    public static void Run()
    {
        // Å gjøre verdier nullable kan ha stor verdi i applikasjoner
        // DateTime er for eksempel en value type. Hva om en kunde har et felt kalt Birthdate,
        // men kunden ikke har fylt inn bursdagen sin enda i skjemaet, eller det er valgfritt.
        // Når man skal lagre det i databasen, er det veldig verdifult å kunne lagre det som
        // null, i motsetning til å gi en bestemt verdi for alle slike kunder. Er det null
        // vet man da at kunden ikke har oppgitt bursdagen.

        // Man kan ikke initialisere en value type med verdien null
        // DateTime dateTimeCannotBeNull = null;

        // Men man kan gjøre den nullable! To måter, den ene kortere og lettere enn den andre
        Nullable<DateTime> langMetode = null;
        DateTime? kortereMetode = null;

        // En value type har tre nyttige metoder man bruker hele tiden
        // Egentlig er vel ikke den under så nyttig? Den krasjer jo hvis verdien er null,
        // noe den jo har stor sannsynlighet for hvis den er nullable.
        // Console.WriteLine($"Value: {kortereMetode.Value}");
        // Men disse ser jeg nytten i
        Console.WriteLine($"GetValueOrDefault: {kortereMetode.GetValueOrDefault()}");
        Console.WriteLine($"HasValue: {kortereMetode.HasValue}");

        // Man kan ikke bare helt uten videre konvertere mellom nullables og value types,
        // selv om nullablen har en verdi annet enn null.
        // Men andre veien går fint (legg merket til at kortereMetode fint kan få verdien til
        // DateTimen dagensDato)
        DateTime dagensDato = DateTime.Today;
        kortereMetode = dagensDato;
        Console.WriteLine($"kortereMetode: {kortereMetode}");
        // dagensDato = kortereMetode; // dagensDato kan ikke på nytt få verdien sin tilbake
        // Men dette hadde jo gått helt fint
        DateTime nyDagensDato = DateTime.Today;
        dagensDato = nyDagensDato;

        // Kommet til 4 min
    }
}