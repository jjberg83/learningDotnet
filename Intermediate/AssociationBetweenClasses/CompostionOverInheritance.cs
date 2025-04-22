namespace Intermediate.AssociationBetweenClasses;
public class CompositionOverInheritance
{
    public static void Run()
    {
        Gathering gatheringKnøttekor = new Gathering();
        gatheringKnøttekor.StartTime = new DateTime(2025, 04, 22);
        gatheringKnøttekor.EndTime = new DateTime(2025, 04, 22);
        Knøttekor knøttekor = new Knøttekor(gatheringKnøttekor);
        knøttekor.Pølseansvarlig();

    
        Gladmat gladmat = new Gladmat(new Gathering());
        gladmat.Gathering.


    }
}