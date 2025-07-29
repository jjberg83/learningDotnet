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
    public static void Run()
    {
        /*
        Lambda expressions er anonyme metoder som ikke har:
        - navn
        - access modifier
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
        
        CheapBooks(BookRepository.GetBooks());

    }
}