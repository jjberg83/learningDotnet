namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;

public class BouvetStaff
{
    public void ListAllExpertise(List<BouvetAnsatt> ansatte)
    {
        foreach (BouvetAnsatt ansatt in ansatte)
        {
            ansatt.SummarizeExpertize();
        }
    }
}
