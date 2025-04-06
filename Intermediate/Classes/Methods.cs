using System.Runtime.InteropServices;

namespace Intermediate.Classes;
public static class Methods
{
    public static void Run()
    {
        
        // Man kan legge inn et varierende antall parametere til metoden
        int add3 = Calculator.Add(new int[]{1,2,3});
        int add4 = Calculator.Add(new int[]{1,2,3,4});
        int add5 = Calculator.Add(1,2,3,4,5);
        int add6 = Calculator.Add(1,2,3,4,5,6);
        Console.WriteLine(add3);
        Console.WriteLine(add4);
        Console.WriteLine(add5);
        Console.WriteLine(add6);

        // Hva blir verdien av a etter at den første Add varianten har gjort jobben sin?
        var a = 1;
        RefModifier.Add(a);
        Console.WriteLine($"a: {a}");

        // Hva blir verdien av b etter at den andre Add varianten har gjort jobben sin?
        // Mosh mener man ALDRI bør bruke ref modifier, men andre gjør det så man må forstå det.
        var b = 1;
        RefModifier.Add(ref b);
        Console.WriteLine($"b: {b}");

        // Og hva blir verdien av c?
        // Aldri bruk out modifier heller
        var c = 1;
        RefModifier.AddPlus(out c, out string j);
        Console.WriteLine($"c: {c}, j: {j}");

        // Det at man sier at man initialiserer c med verdien 1
        // er altså helt ubetydelig. Det blir rett og slett ignorert.
        // Poenget til out er at man skal gi verdi til variabelen inni metoden.
        // Men den returnerer fortsatt ingenting.

        // Her er eksemple der man ikke initialiserer variabelen på forhånd
        // Dette er altså et alternativ til følgende kode
        // int a = 2;
        // string b = "Jørund";
        RefModifier.AddPlus(out int d, out string u);
        Console.WriteLine($"d: {d}");
        
        // Man kan altså nå variablene j og u nå
        // De blir rett og slett laget inni metodene
        Console.WriteLine($"j: {j}");
        Console.WriteLine($"u: {u}");

        var firstPoint = new Point(2,3);
        // Så lenge man har en constructor uten parametere i, kan man bruke
        // object initializers som her
        var secondPoint = new Point
        {
            X = 5
        };

        Console.WriteLine(firstPoint.X);
        Console.WriteLine(firstPoint.Y);
        Console.WriteLine(secondPoint.X);
        Console.WriteLine(secondPoint.Y);
        secondPoint.Move(0, -4);
        Console.WriteLine($"x: {secondPoint.X}, y: {secondPoint.Y}");
        secondPoint.Move(new Point(-2, 14));
        Console.WriteLine($"x: {secondPoint.X}, y: {secondPoint.Y}");
        // Her legger vi inn null som argument. Vil føre til at alt krasjer
        // hvis vi ikke tar høyde for det i metoden selvsagt
        secondPoint.Move(null);


    }
}
