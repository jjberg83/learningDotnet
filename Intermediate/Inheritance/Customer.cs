namespace Intermediate.Inheritance;


public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public void Promote()
    {
        // under bruker vi named argument i parammetere (unngår ambiguity når man har flere argumenter
        // av samme type, og kan også endre på rekkefølgen, men de uten navn må da komme først)
        int rating = CalculateRating(excludeOrders: true);
        if(rating == 0)
            Console.WriteLine("Customer promoted to level 1");
        else
            Console.WriteLine("Customer promoted to level 2");
    }

    // Denne metoden skal kun brukes inni klassen fordi det har med implementation details å gjøre
    // public blir derfor feil å bruke her
    // private ville stengt den ute for alle andre klasser
    // protected gjør at derived klassen GoldCustomer kan bruke den
    protected int CalculateRating(bool excludeOrders)
    {
        return 0;
    }

}

