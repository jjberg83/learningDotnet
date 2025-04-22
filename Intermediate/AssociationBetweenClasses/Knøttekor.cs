namespace Intermediate.AssociationBetweenClasses;
public class Knøttekor
{
    private readonly Gathering _gathering;
    public Knøttekor(Gathering gathering)
    {
        _gathering = gathering;
    }
    public void Pølseansvarlig()
    {
        _gathering.Statement("Pølseansvarlig våren 2025 er Jørund");
    }
}
