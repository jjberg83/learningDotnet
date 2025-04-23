namespace Intermediate.AssociationBetweenClasses;

public class FestivalOver18
{
    public int BongerBrukt { get; set; }
    public void Bartender()
    {
        Console.WriteLine("Hvilken drink vil du ha?");
    }

    public void BrukDrikkeBong()
    {
        BongerBrukt +=1;
    }

    public void HvorMyeHarJegHatt()
    {
        Console.WriteLine($"Du har drukket {BongerBrukt} enheter så langt");
    }
}
