namespace Intermediate.Inheritance;

public class GoldCustomer : Customer
{
    // under skriver man this for å kunne se hva man også får fra parent class
    // Man ser at man faktisk når CalculateRating metoden, fordi proteted tillater
    // derived classes adgang til disse
    public void OfferVoucher()
    {
        int rating = this.CalculateRating(excludeOrders: false);
    }
}
