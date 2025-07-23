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
        Console.WriteLine();

        // I stedet bruker man klassen kalt ListGeneric, som bruker Generics
        // Man spesifiserer hva man ønsker å legge inn i listen fra gang til gang (og dermed er datatypen bestemt 
        // ved runtime, og man unngår boxing og unboxing).
        // Men fordelen med listen over er jo at den kan ta inn mange forskjellige
        // datatyper i samme instans av listen.
        // Her lager vi en instans med int som datatype input
        var genericListMedIntegers = new ListGeneric<int>();
        genericListMedIntegers.Add(343);
        Console.WriteLine($"genericListMedIntegers[0]: {genericListMedIntegers[0]}");
        // Og her lager vi en instans av samme klasse, men denne gang med string som datatype input
        var genericListMedStrings = new ListGeneric<string>();
        genericListMedStrings.Add("lasdjf");
        Console.WriteLine($"genericListMedStrings[0]: {genericListMedStrings[0]}");

        // I praksis er det veldig sjelden at man trenger å lage egne Generic klasser, siden dotnet allerede
        // har en god samling her: System.Collections.Generic
        // System.Collections.Generic.

        // I de få tilfellene der vi trenger å lage egne Generics, viser resten av leksjonen dette.
        // Vi går i gang med å lage en generisk dictionary
        // Tipper vi lager det inni klasser, siden alt i C# er klasser. Her ser Mosh antageligvis for
        // seg at denne klassen skal inneholde masse annet, som er irrelevant i dette tilfelle. Det som
        // er relevant er at den også skal ha en generisk dictionary, som vi nå lager inni klassen (se klassen kalt DictionaryGeneric.cs)
        // Under spesifiserer vi at key skal være string og value skal være Book. Men kan gjøre andre valg her, siden det er generisk.

        var bookDictionary = new DictionaryGeneric<string, Book>();
        bookDictionary.Add("Lord of the Rings", new Book());
        bookDictionary.Add("Hitchhikers Guide to the Galaxy", new Book());

        // Hvis man ønsker å begrense hvilke datatyper T kan være for en Generic, 
        // må man bruke constraints. Se i klassen Utilities.cs for begynnelsen på dette.
        // Totalt finnes 5 typer constraints innen Generics:
        // 1 - where T : IInterface
        // 2 - where T : EnKlasse (eller noen av dens subklasser)
        // 3 - where T : struct (altså en value type)
        // 4 - where T : class (altså en reference type)
        // 5 - where T : new() (et objekt som har en default constructor)
        var utility = new Utilities();

        // Her bruker man Max metoden som tar inn ints
        Console.WriteLine(utility.Max(2, 1));
        Console.WriteLine(utility.Max(100, 200));

        // Og her bruker man Max metoden som tar inn enhver datatype
        // men med en constraint, nemlig at datatypen som tas inn kan sammenlignes
        // det vil si at datatypen må implementere IComparable interfacet
        Console.WriteLine(utility.Max('a', 'j')); // a gir ascii 97, mens j gir 106, viktig å bruke single quotes, fordi da bruker man ascii sammenligning med sine ASCII koder, string gir en annen sammenligning
        Console.WriteLine(utility.Max('a', 'A')); // a gir ascii 97, mens A gir 65

        // Over har vi brukt én type constraint, nemlig interface (1). Som nevnt over finnes totalt det 5 constraint typer:
        // 1 - where T : IInterface
        // 2 - where T : EnKlasse (eller noen av dens subklasser)
        // 3 - where T : struct (altså en value type)
        // 4 - where T : class (altså en reference type)
        // 5 - where T : new() (et objekt som har en default constructor)

        // Nå skal vi se på (2), en constraint på en hel klasse (se klassen kalt DiscountCaluclator)
        // Først legger vi inn Product klassen inn som T
        var productDiscount = new DiscountCalculator<Product>();
        var ball = new Product { Title = "Fotball", Price = 100f };
        var ballRabatt = productDiscount.CalculateDiscount(ball);
        Console.WriteLine($"Rabatt på ball: {ballRabatt}, pris: {ball.Price}");

        // Og så legger vi en subklasse av Product, Book, inn som T
        var bookDiscount = new DiscountCalculator<Book>();
        var biografi = new Book { Title = "Gunhild Stordalen", Price = 250f, Isbn = "oiu3ro34q3rfsklj" };
        var bokRabatt = bookDiscount.CalculateDiscount(biografi);
        Console.WriteLine($"Rabatt på bok: {bokRabatt}, pris: {biografi.Price}");

        // Så skal vi se på (3), når T er en value type (se klassen kalt Nullable)
        // Under ser vi 1 value type. Vi klarer ikke å gjøre den om til null.
        char bokstav = 'j';
        // bokstav = null;

        // Men ved å sende denne value typen inn som T i klassen Nullable, som har en metode
        // som er designet for å hjelpe denne value typen med dette, går det
        Console.WriteLine();
        var nullablebokstav = new Nullable<char>();
        object bokstavKonvertert = nullablebokstav.MakeNullable(bokstav);
        Console.WriteLine($"bokstavKonvertert: {bokstavKonvertert}, vi ser verdien er der fortsatt, men nå er variabelen et objekt");
        bokstavKonvertert = null;
        Console.WriteLine($"bokstavKonvertert: {bokstavKonvertert}, Men nå kan vi gjøre den om til null siden det er et object");

        Console.WriteLine();
        var nullableIntMedVerdi = new Nullable<int>(7);
        Console.WriteLine($"HasValue: {nullableIntMedVerdi.HasValue}");
        Console.WriteLine($"Value: {nullableIntMedVerdi.GetValueOrDefault()}");

        Console.WriteLine();
        var nullableIntUtendVerdi = new Nullable<int>();
        Console.WriteLine($"HasValue: {nullableIntUtendVerdi.HasValue}");
        Console.WriteLine($"Value: {nullableIntUtendVerdi.GetValueOrDefault()}");

        // Så over til (5), hvor constrainten er at objektet må ha en default constructor (se Utilites)
        // Denne forsto jeg ikke hvordan jeg skulle bruke.
        var utilites = new Utilities();
    }
}