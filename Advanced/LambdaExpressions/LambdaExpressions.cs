namespace Advanced.LambdaExpressions;
public class LambdaExpressions
{
    public delegate int Squaring(int number);
    public static int SquareNumber(int number)
    {
        return number * number;
    }

    private static void CheapBooks(List<Book> bookRepository)
    {
        foreach (Book book in bookRepository)
        {
            if (book.Price < 50f)
                Console.WriteLine(book.Title);
        }
    }

    // Dette er en predicate, et annet navn for en metode (eller lambda expression)
    // som returnerer en boolean verdi. Den tar ofte inn en input og søker gjennom
    // en samling av noe.
    static bool IsCheaperThan50Dollars(Book book)
    {
        return book.Price < 50f;
    }
    public static void Run()
    {
        /*
        Lambda expressions er anonyme metoder som ikke har:
        - navn
        - access modifier (public, private osv)
        - return statements (eller return type)

        Blir brukt for å slippe å skrive masse kode.

        Syntaks:
        args => expression
        (les: args goes to expression)
        Med 1 argument blir det:
        x => expression
        Med flere argumenter blir det:
        (x,y,z) => expression
        Med ingen argument blir det:
        () => expression
        */

        // Her kaller vi eskplisistt på en metode skrevet på gamlemåten:
        Console.WriteLine(SquareNumber(2));

        // Og her blir det samme gjort med  en custom delegate som kun er knyttet til EN metode.
        // Man må intstansiere delegaten først, og så igangsette den.
        // Delegaten her peker altså til en metode skrevet på gamlemåten.
        // Squaring squaring = new Squaring(SquareNumber);
        // Console.WriteLine(squaring(2));

        // Her gjør man det samme som den over, men i stedet for at delegaten peker
        // til en eksplisitt skrevet metode skrevet på gamlemåten, peker den til
        // en lambda expression. Her opprettet vi en custom delegate.
        // Squaring squaring = new Squaring(number => number * number);
        // Console.WriteLine(squaring(2));
        // Console.WriteLine(squaring(3));

        // Her bruker vi en default delegate (husk Func og Action, func returnerer noe, action returnerer void)
        // Litt mindre kode her, siden vi slipper å lage en custom delegate.
        Func<int, int> squaring = number => number * number;
        Console.WriteLine(squaring(2));
        Console.WriteLine(squaring(5));

        // Lambda expressions har tilgang til alt definert inni metoden den ligger inni. 
        // Her er vi inne i metoden Run, og derfor er alle lokale variabler der
        // også tilgjengelig for alle lambda expressions
        const int factor = 5;

        Func<int, int> multiplier = numberToBeMultiplied => numberToBeMultiplied * factor; // Vi får tak i konstanten her

        Console.WriteLine(multiplier(2));

        // Skriv lambda expression som returnerer alle bøker fra BookRepository
        // som er billigere enn 50
        // Han bruker en predicate, altså en metode (eller en lambda expression) som returnerer en boolean verdi
        // (han gjør det først med en eksplisitt skrevet metode, se metoden kalt IsCheaperThan50Dollars over)

        List<Book> books = BookRepository.GetBooks();

        // Trykke man punktum under og ser på argumentene for alle Find metodene,
        // ser man at de tar inn Predicate som argument, altså vil predicaten vi skrev over
        //, som ikke er noe annet enn en metode som returnerer en bool, være perfekt.
        // books.Find

        // Vi bruker altså en eksplisitt skrevet metode her
        // I dette tilfellet er denne eksplisitt skrevne metoden også en såkalt predicate
        List<Book> veryCheapBooks = books.FindAll(IsCheaperThan50Dollars);

        foreach (Book book in veryCheapBooks)
        {
            Console.WriteLine(book.Title);
        }

        // Og her er instruktørens løsning på det samme bare med bruk av lambda expressions
        // Argumentet inni FindAll er også denne gangen en predicate, men i lambda expression format
        // Altså ikke en eksplisitt skrevet metode
        List<Book> veryCheapLambdaBooks = books.FindAll(book => book.Price < 50f);

        foreach (Book book in veryCheapLambdaBooks)
        {
            Console.WriteLine(book.Title);
        }

    }
}