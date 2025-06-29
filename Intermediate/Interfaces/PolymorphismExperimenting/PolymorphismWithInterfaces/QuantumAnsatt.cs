namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInterfaces;

public class QuantumAnsatt : IBouvetAnsatt
{
    private readonly int _bouvetID;
    public string Name { get; set; }
    public QuantumAnsatt(int bouvetID, string name)
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
        Console.WriteLine($"{Name} analyserer og visualiserer data ved hjelp av Power BI og Fabric");
    }
}