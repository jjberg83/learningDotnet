namespace Intermediate.Classes;

public class Invoice
{
    public int Id;
    public float Amount;
    public string? Currency;

    // Like greit å initialisere her, så lenge man alltid initialiserer listen på 
    // samme måte (og ikke inni constructoren)
    public List<Order> Orders = new();

    public Invoice()
    {

    }
}
