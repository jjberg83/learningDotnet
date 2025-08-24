namespace Advanced.LINQ;

public class LINQ
{
    public static void Run()
    {
        var books = new BookRepository().GetBooks();

        // Her med gammeldags metode
        // var cheapestOnes = cheapBooks(books);

        // Her lager vi en liste med billige bøker, og på direkten, sorterer dem alfabetisk, med LINQ
        // Vi bruker en syntaks som kalles "LINQ Extension Methods"
        var cheapestOnes = books
                                .Where(b => b.Price < 60f)
                                .OrderBy(b => b.Title);
        // I leksjonen om lambda expression så vi noe lignende, men det var med en metode
        // FindAll som jeg tror er spesifikk for List (og her har jeg en IEnumerable). 
        // Where er en LINQ metode for enhver collection tror jeg

        foreach (Book book in cheapestOnes)
        {
            Console.WriteLine($"{book.Title} costs {book.Price}");
        }

        Console.WriteLine("--------------------------------");
        // Her lager vi en ny list med LINQ, men denne gangen returnerer vi en liste med strings,
        // fordi i den siste metoden vi "chainer", spesifiserer at det kun er Title vi er ute etter.
        // Title er av typen string, og dermed blir det en liste med strings.
        // Legg også merke til at jeg sorterer alfabetisk i synkende rekkefølge (fra z - a)
        var cheapestOnesAsStrings = books
                                        .Where(b => b.Price < 60f)
                                        .OrderByDescending(b => b.Title)
                                        .Select(b => b.Title);

        foreach (string title in cheapestOnesAsStrings)
        {
            Console.WriteLine(title);
        }

        Console.WriteLine("---------------------------------");
        // Og til slutt returnerer vi en liste med floats, med de dyreste først
        var cheapestOnesAsFloats = books
                                        .Where(b => b.Price < 60f)
                                        .OrderByDescending(b => b.Price)
                                        .Select(b => b.Price);


        foreach (float price in cheapestOnesAsFloats)
        {
            Console.WriteLine(price);
        }

        Console.WriteLine("----------------------------------");
        // Her spør vi om det samme som over, men vi bruker syntaksen som kalles "LINQ Query Operators"
        // Det er personlig hvilken stil du vil følge. Denne syntaksen er visstnok enklere å lese, men
        // ikke like kraftig. Den inneholder ikke alle metodene, som OrderByDescending for eksempel.
        // I tillegg oversettes alt under til stilen over under the hood. Jeg holder meg til den øverst.
        var evenCheaperThanCheapesOnesAsFloats =
        from g in books
        where g.Price < 60f
        orderby g.Price
        select g.Price;


        foreach (float price in evenCheaperThanCheapesOnesAsFloats)
        {
            Console.WriteLine(price);
        }

        // Nå skal jeg finne den ene boken som heter "Travel the world"
        // Legg merke til at vi nå får en Book, ikke en IEnumerable med Books
        // Det finnes også en metode kalt bare Single, men finnes ikke boken, krasjer applikasjonen.
        // Med SingleOrDefault får man null tilbake hvis boken ikke finnes.


        var traveTheWorldTypo = books.SingleOrDefault(b => b.Title == "Travel the worldh");
        if (traveTheWorldTypo != null)
            Console.WriteLine($"{traveTheWorldTypo.Title} costs {traveTheWorldTypo.Price}");
        else
            Console.WriteLine("Boken er null, altså finnes den ikke");

        // Her er uten trykkfeil, og boken finnes
        var traveTheWorld = books.SingleOrDefault(b => b.Title == "Travel the world");
        if (traveTheWorld != null)
            Console.WriteLine($"{traveTheWorld.Title} costs {traveTheWorld.Price}");
        else
            Console.WriteLine("Boken er null, altså finnes den ikke");

        // Her ser vi svakheten med SingleOrDefault, når det finnes to elementer med samme navn
        // Man får en exception som må håndteres
        try
        {
            // SingleOrDefault gir deg en exception hvis det finnes to stk med samme navn
            var theWondersOfTheWorld = books.SingleOrDefault(b => b.Title == "The wonders of the world");
            Console.WriteLine($"{theWondersOfTheWorld.Title} koster {theWondersOfTheWorld.Price}");
        }
        catch
        {
            Console.WriteLine("SingleOrDefault ga en exception, og man kan ikke få ut tittel eller pris fra en exception");
        }

        // Når det finnes to elementer med samme navn, er First et bedre alternativ
        var firstTheWondersOfTheWorld = books.FirstOrDefault(b => b.Title == "The wonders of the world");
        if (firstTheWondersOfTheWorld != null)
            Console.WriteLine($"First instance of {firstTheWondersOfTheWorld.Title} costs {firstTheWondersOfTheWorld.Price}");
        else
            Console.WriteLine("Boken finnes ikke i BookRepository");

        // Og her finnes siste tilfelle
        var lastTheWondersOfTheWorld = books.LastOrDefault(b => b.Title == "The wonders of the world");
        if (lastTheWondersOfTheWorld != null)
            Console.WriteLine($"Last instance of {lastTheWondersOfTheWorld.Title} costs {lastTheWondersOfTheWorld.Price}");
        else
            Console.WriteLine("Boken finnes ikke i BookRepository");

        Console.WriteLine("---------------------");
        // Her henter vi ut et utvalg av listen
        var utvalg = books.Skip(2).Take(3);
        foreach (var book in utvalg)
            Console.WriteLine(book.Title);

        // Her teller vi antall bøker i BookRepository
        Console.WriteLine($"Det finnes {books.Count()} i BookRepository");

        // Her teller vi et utvalg, utvalget har bare 2, selv om vi tar 3, fordi vi starter på de to siste elementene
        Console.WriteLine($"Det finnes {books.Skip(5).Take(3).Count()} i utvalget av BookRepository");

        // Her finner vi dyreste og billigste bok
        Console.WriteLine($"Den dyreste boken koster {books.Max(b => b.Price)}");
        Console.WriteLine($"Den billigste boken koster {books.Min(b => b.Price)}");

        // Summering
        Console.WriteLine($"Bøkene koster til sammen {books.Sum(b => b.Price)}");

        // Snitt
        Console.WriteLine($"Bøkene koster i snitt {books.Average(b => b.Price)}");

    }


    // private static IEnumerable<Book> cheapBooks(IEnumerable<Book> books)
    // {
    //     var cheapBooks = new List<Book>();
    //     foreach (Book book in books)
    //     {
    //         if (book.Price <= 60f)
    //         {
    //             cheapBooks.Add(book);
    //         }

    //     }
    //     return cheapBooks;

    // }

}