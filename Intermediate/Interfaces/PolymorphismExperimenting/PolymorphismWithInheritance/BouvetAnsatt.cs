namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;
public abstract class BouvetAnsatt
{
    private readonly int _bouvetID;
    public string Name { get; set; }
    public BouvetAnsatt(int bouvetID, string name)
    {
        _bouvetID = bouvetID;
        Name = name;
    }

    public abstract void SummarizeExpertize();
}
