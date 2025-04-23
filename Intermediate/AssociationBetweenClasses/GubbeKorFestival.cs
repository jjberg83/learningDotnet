namespace Intermediate.AssociationBetweenClasses;

public class GubbeKorFestival
{
    private Gathering _gathering;
    private FestivalOver18 _festivalOver18;
    private Kor _kor;

    public GubbeKorFestival()
    {
        _gathering = new Gathering();
        _festivalOver18 = new FestivalOver18();
        _kor = new Kor();
    }

    public void Beskjed(string beskjed)
    {
        _gathering.Statement(beskjed);
    }

    public void HilsPåBartender()
    {
        _festivalOver18.Bartender();
    }

    public void Lederinfo()
    {
        _kor.Sangleder();
    }
}