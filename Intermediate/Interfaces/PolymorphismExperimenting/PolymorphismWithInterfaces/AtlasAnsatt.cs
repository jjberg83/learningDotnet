namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInterfaces;

public class AtlasAnsatt : IBouvetAnsatt
{
    private readonly int _bouvetID;
    public string Name { get; set; }
    public AtlasAnsatt(int bouvetID, string name)
    {
        if (bouvetID <= 0)
        {
            throw new Exception();
        }
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullReferenceException();
        }
        _bouvetID = bouvetID;
        Name = name;
    }

    public void SummarizeExpertise()
    {
        using (var streamWriter = new StreamWriter("/Users/jjberg/Github/learningDotnet/Intermediate/Interfaces/PolymorphismExperimenting/PolymorphismWithInterfaces/Expertize.txt", true))
        {
            streamWriter.WriteLine($"{Name} jobber backend og koder masse");
        }
    }
}