namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;

public class QuantumAnsatt : BouvetAnsatt
{
    public QuantumAnsatt(int bouvetID, string name) : base(bouvetID, name)
    {

    }

    public override void SummarizeExpertize()
    {
        Console.WriteLine($"{this.Name} analyserer og visualiserer data ved hjelp av Power BI og Fabric");
    }
}
