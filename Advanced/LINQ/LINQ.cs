namespace Advanced.LINQ;

public class LINQ
{
    public static void Run()
    {
        var books = new BookRepository().GetBooks();

        // Her med gammeldags metode
        // var cheapestOnes = cheapBooks(books);

        // Her lager vi en liste med billige bøker, og på direkten, sorterer dem alfabetisk, med LINQ
        var cheapestOnes = books.Where(b => b.Price < 60f).OrderBy(b => b.Title);
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
        var cheapestOnesAsStrings = books.Where(b => b.Price < 60f).OrderByDescending(b => b.Title).Select(b => b.Title);

        foreach (string title in cheapestOnesAsStrings)
        {
            Console.WriteLine(title);
        }

        Console.WriteLine("---------------------------------");
        // Og til slutt returnerer vi en liste med floats, med de dyreste først
        var cheapestOnesAsFloats = books.Where(b => b.Price < 60f).OrderByDescending(b => b.Price).Select(b => b.Price);

        foreach (float price in cheapestOnesAsFloats)
        {
            Console.WriteLine(price);
        }

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