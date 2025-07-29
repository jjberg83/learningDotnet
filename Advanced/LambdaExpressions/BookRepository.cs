namespace Advanced.LambdaExpressions;
public class BookRepository
{
    public static List<Book> GetBooks()
    {
        return new List<Book>()
        {
            {new Book() {Title = "Ego is the enemy", Price = 40f}},
            {new Book() {Title = "Tribe of mentors", Price = 60f}}
        };
    }
}
