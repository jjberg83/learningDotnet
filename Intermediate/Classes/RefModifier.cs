namespace Intermediate.Classes;

public static class RefModifier
{
    // Den første Add varianten, uten ref
    public static void Add(int a)
    {
        Console.WriteLine($"a kommer inn med verdien {a}");
        a += 2;
        Console.WriteLine($"a inni Add metoden er en lokal variabel som ikke er tilknyttet a utenfor, den henter kun verdien fra referansen til a. Her inne er a sin verdi {a}");
    }
    // Den andre Add varianten, med ref
    // Man må initalisere variabelen man sender inn i metoden på forhånd
    // Metoden kan lese opprinnelig verdi av variabelen som er lagt inn som argument
    public static void Add(ref int a)
    {
        Console.WriteLine($"a kommer inn med verdien {a}");
        a += 2;
        Console.WriteLine($"a sin verdi inni denne metoden er {a}, men her har man med ref koblet referansen inn i bildet, og a utenfor påvirkes");
    }
    // Den tredje Add varianten, med out
    // Out trenger ikke en variabel inn som er initialisert
    // Er den initialisert ødelegger det ikke, men verdien blir ignorert
    // Out MÅ assigne en ny verdi til variabelen som blir lagt inn som argument
    public static void AddPlus(out int a, out string b)
    {
        a = 2;
        b = "Jørund";
    }
}
