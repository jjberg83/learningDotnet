using System.Linq;

namespace Advanced.LINQ;

public class LINQ
{
    public static void Run()
    {
        var books = new BookRepository().GetBooks();

        var cheapestOnes = cheapBooks(books);

        foreach (Book book in cheapestOnes)
        {
            Console.WriteLine(book.Price);
        }

        // La oss finne bøker billigere enn 60 uten LINQ
        // Func<IEnumerable<Book>, IEnumerable<Book>> cheapBooks

        // Nå skal vi bruke LINQ til å finne bøker billigere enn 60

    }

    private static IEnumerable<Book> cheapBooks(IEnumerable<Book> books)
    {
        var cheapBooks = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Price <= 60f)
                cheapBooks.Add(book);
        }
        return cheapBooks;

    }

}