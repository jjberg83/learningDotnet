using System.Runtime.InteropServices;

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

        // I stedet bruker man klassen kalt ListGeneric, som bruker Generics
        // Man spesifiserer hva man ønsker å legge inn i listen fra gang til gang (og dermed er datatypen bestemt 
        // ved runtime, og man unngår boxing og unboxing).
        // Men fordelen med listen over er jo at den kan ta inn mange forskjellige
        // datatyper i samme instans av listen.
        var genericListMedIntegers = new ListGeneric<int>();
        // genericListMedIntegers.Add(343);
        var genericListMedStrings = new ListGeneric<string>();
        // genericListMedStrings.Add("lasdjf");

        // I praksis er det veldig sjelden at man trenger å lage egne Generic klasser, siden dotnet allerede
        // har en god samling her: System.Collections.Generic
        // System.Collections.Generic.

        // I de få tilfellene der vi trenger å lage egne Generics, viser resten av leksjonen dette.
        // Vi går i gang med å lage en generisk dictionary
        // Tipper vi lager det inni klasser, siden alt i C# er klasser. Her ser Mosh antageligvis for
        // seg at denne klassen skal inneholde masse annet, som er irrelevant i dette tilfelle. Det som
        // er relevant er at den også skal ha en generisk dictionary, som vi nå lager inni klassen (se klassen kalt DictionaryGeneric.cs)

        var bookDictionary = new DictionaryGeneric<string, Book>();
        bookDictionary.Add("Lord of the Rings", new Book());
        bookDictionary.Add("Hitchhikers Guide to the Galaxy", new Book());

        // Hvis man ønsker å begrense hvilke datatyper T kan være for en Generic, 
        // må man bruke constraints. Se i klassen Utilities.cs for begynnelsen på dette.
        var utility = new Utilities();

        // Her bruker man Max metoden som tar inn ints
        Console.WriteLine(utility.Max(2, 1));
        Console.WriteLine(utility.Max(100, 200));

        // Og her bruker man Max metoden som tar inn enhver datatype
        // men med en constraint, nemlig at datatypen som tas inn kan sammenlignes
        // det vil si at datatypen må implementere IComparable interfacet
        Console.WriteLine(utility.Max('a', 'j')); // a gir ascii 97, mens j gir 106, viktig å bruke single quotes, fordi da bruker man ascii sammenligning med sine ASCII koder, string gir en annen sammenligning
        Console.WriteLine(utility.Max('a', 'A')); // a gir ascii 97, mens A gir 65

    }
}