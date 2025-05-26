namespace Intermediate.Polymorphism;


internal class SealedClassesAndMembers
{
    public static void Run()
    {
        // Mosh bruker det aldri. Det kan føre til små performance forbedringer, men det
        // klusser til med inheritance hierarkiet, så fordelene er ikke store nok i 
        // forhold til baksidene. 

        // Sealed er det motsatte av abstract. Det gjør at klasser som er sealed
        // ikke kan arves fra. Man kan altså ikke bygge en derived class fra
        // en klasse som er markert med sealed. Som under. Her ser man at man 
        // ikke kan lage klasser som arver fra circle.
        // internal sealed class Circle : Shape
        // {
        //     public override void Draw()
        //     {
        //         Console.WriteLine("Draw a CIRCLE");
        //     }
        // }  

        // Putter man det foran metoden, kan man ikke override denne metoden lenger
        // ned i hierarkiet, altså overskrive den. Men sealed foran metoder kan
        // bare brukes på metoder som er definert som virtual/abstract i base class.
        // I eksempelet nedenfor kunne en potensiell arving fra Circle, la oss si
        // HalfCircle, kunne vært derived fra Circle. Men HalfCircle kunne ikke
        // ha overridet Draw metoden.

        // internal class Circle : Shape
        // {
        //     public sealed override void Draw()
        //     {
        //         Console.WriteLine("Draw a CIRCLE"); // HalfCircle vil aldri kunne skrive noe annet enn dette.
        //     }
        // }    
    }
}