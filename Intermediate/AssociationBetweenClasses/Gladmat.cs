namespace Intermediate.AssociationBetweenClasses;

// Gladmat has-a Gathering og has-a FestivalOver18
public class Gladmat
{
    private Gathering _gathering;
    private FestivalOver18 _festivalOver18;

    public Gladmat()
    {
        _gathering = new Gathering();
        _festivalOver18 = new FestivalOver18();
    }

    public void Beskjed(string beskjed)
    {
        _gathering.Statement(beskjed);
    }

    public void HilsPåBartender()
    {
        _festivalOver18.Bartender();
    }
}
