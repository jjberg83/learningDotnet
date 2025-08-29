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
        // Den kjipe måten
        Nullable<DateTime> langMetode = null;
        // Og den bedre
        DateTime? date = null;

        // En value type har tre nyttige metoder man bruker hele tiden
        // Egentlig er vel ikke den under så nyttig? Den krasjer jo hvis verdien er null,
        // noe den jo har stor sannsynlighet for hvis den er nullable.
        // Console.WriteLine($"Value: {date.Value}");
        // Men disse ser jeg nytten i
        Console.WriteLine($"GetValueOrDefault: {date.GetValueOrDefault()}");//Defaulten avhenger av "original" type. Her blir default verdi 1.jan år 1
        Console.WriteLine($"HasValue: {date.HasValue}");

        // Man kan ikke bare helt uten videre konvertere mellom nullables og value types,
        // selv om nullablen har en verdi annet enn null.
        // Men andre veien går fint (legg merket til at date fint kan få verdien til
        // DateTimen dagensDato)
        DateTime dagensDato = DateTime.Today;
        date = dagensDato;
        Console.WriteLine($"date: {date}");
        // dagensDato = date; // dagensDato kan ikke på nytt få verdien sin tilbake
        // Men dette hadde jo gått helt fint
        DateTime nyDagensDato = DateTime.Today;
        dagensDato = nyDagensDato;

        // Skal vi overføre en verdi fra en nullable til en value type (her: DateTime)
        // kan vi bruke en av de to nyttige metodene. Da overføres en verdi, selv om den er null 
        // (er den null overføres default verdien, som for en DateTime ville vært 1.jan år 1)
        dagensDato = date.GetValueOrDefault();

        // Null Coalescing Operator
        // Uten den får vi mye boilerplate kode
        DateTime? nullableDate = null;
        DateTime datetimeDate;

        // Masse boilerlate kode
        // if (nullableDate != null)
        //     datetimeDate = nullableDate.GetValueOrDefault();
        // else
        //     datetimeDate = DateTime.Today;

        // Mindre boilerplate kode
        // datetimeDate = nullableDate != null ? nullableDate.GetValueOrDefault() : DateTime.Today;

        // Og endelig til slutt, med null coalescing operator
        // Les det som: hvis nullableDate har verdi, gi denne verdien, hvis ikke gi DateTime.Today
        datetimeDate = nullableDate ?? DateTime.Today;

        Console.WriteLine($"datetimeDate: {datetimeDate}");


    }
}