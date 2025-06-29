namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInterfaces;

public class PolymorphismWithInterfaces
{
    public static void Run()
    {
        var martin = new QuantumAnsatt(123, "Martin");
        AtlasAnsatt victor = new(321, "Victor");
        QuantumAnsatt jørund = new(456, "Jørund");
        var trond = new AtlasAnsatt(345, "Trond");

        List<IBouvetAnsatt> ansatte = new() { martin, victor, jørund, trond };
        var stab = new BouvetStaff();
        stab.ListAllExpertise(ansatte);
    }
}
