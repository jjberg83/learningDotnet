namespace Intermediate.Inheritance;
public class Bygning
{
    private readonly bool tillatelse;

    public Bygning()
    {
        Console.WriteLine("Bygning er skapt");
    }

    // skriver man bare parameteren, kan man trykke CMD + . og velge "Create and assign field"
    // for å lage private field og gi den samme verdi som parameteren
    public Bygning(bool tillatelse) 
    {
        this.tillatelse = tillatelse;
    }
}
