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

        // Problemet med ListIntegers klassen er at hvis jeg har lyst til å legge inn
        // Book inn i listen vil det ikke fungere. Jeg må skrive en helt lik klasse
        // med unntak at den tar inn Book i stedet for int. Og slikt må jeg fortsette
        // for alle nye typer. Mye duplisering av kode altså.

        // Jeg kunne skrevet en klasse som den du ser i ListObjects.cs, som tar inn object.
        // Alt i C# er jo object, så det funker. Men performance er skikkelig dårlig.
        // Ting blir boxed og unboxed, som er skikkelig dårlig for performance.

        // Her ser man at det fungerer.
        var objectList = new ListObjects();
        objectList.Add(7);
        objectList.Add("Jørund");
        objectList.Add(true);
        objectList.Add(new Book());

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(objectList[i]);
        }

        // Sett til 02.40

    }
}