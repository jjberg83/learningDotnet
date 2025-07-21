namespace Advanced.Generics;

// I denne klassen har vi noe av T-greiene i signaturen
// Denne constrainten på klassen gjør at metoden og klassen kan gjøre bruk av
// alt som er enten Product klassen, eller noen av dens subclasses, som Book
public class DiscountCalculator<TProduct> where TProduct : Product
{
    public float CalculateDiscount(TProduct product)
    {
        return product.Price * 0.1f;
    }
}
