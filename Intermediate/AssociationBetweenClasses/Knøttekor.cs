namespace Intermediate.AssociationBetweenClasses;

// Knøttekor has-a Gathering og has-a Kor
public class Knøttekor
{
    private Kor _kor;

    private Gathering _gathering;

    public Knøttekor()
    {
        _kor = new Kor();
        _gathering = new Gathering();
    }

    public void Beskjed(string beskjed)
    {
        _gathering.Statement(beskjed);
    }

    public void Lederinfo()
    {
        _kor.Sangleder();
    }
    
}
