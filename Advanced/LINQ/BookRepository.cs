namespace Advanced.LINQ;

public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "From rags to riches", Price = 150.0f},
            new Book() { Title = "The wonders of the world", Price = 250.0f},
            new Book() { Title = "Live, before you die", Price = 300.0f},
            new Book() { Title = "Travel the world", Price = 50.0f},
            new Book() { Title = "Stop drinking, you're killing me", Price = 100.0f},
            new Book() { Title = "How to enjoy wine, the right way", Price = 30.0f},
        };
    }
}
