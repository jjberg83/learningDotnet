namespace Advanced.Generics;
public class Generics
{
    public static void Run()
    {
        // Først litt repetisjon som er relevant for å forklare hvorfor Generics er bra

        // Boxing er når en value type konverteres til en reference type
        // Selv om 7 er int, er alle ints også objects, så dette går
        object objekt = 7;

        // Unboxing er når vi går andre veien, altså at reference types
        // konverteres til value types
        int tall = (int)objekt;

        // Det ligner veldig på upcasting og downcasting siden, men der så
        // vi på base classes og derived classes. Her skifter vi mellom
        // reference og value types. Når man har boxing lagrer man en value
        // type i heapen (ved å bokse det inn i en referansetype). Når 
        // man unboxer, tar man ut value typen fra reference typen. 

        // Det har en kostnad fordi man må allokere plass av og på i heapen, 
        // i tillegg til man må sjekke typer.

        // Her tester jeg klassen ListIntegers, som er den jeg skrev med utgangspunkt
        // i en "skall klasse" skrevet av Mosh (fields og metoder var skrevet med 
        // NotImplementedExceptions)
        var listIntegers = new ListIntegers();
        // Har ikke lagt til noen elementer i klassens private backing field, så burde
        // heller ikke få noe igjen første gang jeg spør om noe fra index 0
        // Får en IndexOutOfRangeException
        try
        {
            Console.WriteLine($"listIntegers[0]: {listIntegers[0]}"); 
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        // Legger til et element, og alt går bra
        listIntegers.Add(42);
        Console.WriteLine($"listIntegers[0]: {listIntegers[0]}"); 

    }
}