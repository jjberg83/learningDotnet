using Microsoft.VisualBasic;

namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInterfaces;
public class BouvetStaff
{
    public void ListAllExpertise(List<IBouvetAnsatt> ansatte)
    {
        foreach (IBouvetAnsatt ansatt in ansatte)
        {
            ansatt.SummarizeExpertise();
        }
    }
}
