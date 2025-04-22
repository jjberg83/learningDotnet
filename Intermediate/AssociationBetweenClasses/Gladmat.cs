namespace Intermediate.AssociationBetweenClasses;

public class Gladmat
{
    private readonly Gathering _gathering;
    public Gladmat(Gathering gathering)
    {
        _gathering = gathering;
    }
    public void Mingling()
    {
        _gathering.Statement("Bla bla bla");
    }
}
