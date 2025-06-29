namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;
public class PolymorphismWithInheritance
{
    public static void Run()
    {
        var martin = new QuantumAnsatt(456, "Martin");
        AtlasAnsatt trond = new(599, "Trond");
        QuantumAnsatt jørund = new(678, "Jørund");
        var victor = new AtlasAnsatt(613, "Victor");

        var ansatte = new List<BouvetAnsatt>() { martin, trond, jørund, victor };
        var stab = new BouvetStaff();
        stab.ListAllExpertise(ansatte);
    }
}