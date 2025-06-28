namespace Intermediate.Interfaces.PolymorphismExperimenting.PolymorphismWithInheritance;

public class AtlasAnsatt : BouvetAnsatt
{
    public AtlasAnsatt(int bouvetID, string name) : base(bouvetID, name)
    {

    }

    public override void SummarizeExpertize()
    {
        using (var streamWriter = new StreamWriter("/Users/jjberg/Github/learningDotnet/Intermediate/Interfaces/PolymorphismExperimenting/PolymorphismWithInheritance/Expertize.txt", true))
        {
            streamWriter.WriteLine($"{this.Name} jobber backend og koder masse");
        }
    }
}
