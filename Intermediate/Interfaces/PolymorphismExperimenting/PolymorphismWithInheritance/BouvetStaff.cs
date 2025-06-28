namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;

public class BouvetStaff
{
    public List<BouvetAnsatt> Ansatte { get; set; }
    public BouvetStaff(List<BouvetAnsatt> ansatte)
    {
        Ansatte = ansatte;
    }

    public void ListAllExpertise()
    {
        foreach (BouvetAnsatt ansatt in Ansatte)
        {
            ansatt.SummarizeExpertize();
        }
    }
}
