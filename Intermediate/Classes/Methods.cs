using System.Runtime.InteropServices;

namespace Intermediate.Classes;

public static class Calculator
{
    // Uten params kan man ikke kalle på metoden som man gjør i variabelen add5 og add6
    // public static int Add(int[] numbers)
    public static int Add(params int[] numbers)
    {
        int result = 0;
        foreach (int n in numbers)
        {
            result += n;
        }
        return result;
    }
}

public static class RefModifier
{
    // Den første Add varianten, uten ref
    public static void Add(int a)
    {
        a += 2;
    }
    // Den andre Add varianten, med ref
    // Man må initalisere variabelen man sender inn i metoden på forhånd
    // Metoden kan lese opprinnelig verdi av variabelen som er lagt inn som argument
    public static void Add(ref int a)
    {
        a += 2;
    }
    // Den tredje Add varianten, med out
    // Out trenger ikke en variabel inn som er initialisert
    // Er den initialisert ødelegger det ikke, men verdien blir ignorert
    // Out MÅ assigne en ny verdi til variabelen som blir lagt inn som argument
    public static void AddPlus(out int a, out string b)
    {
        a = 2;
        b = "Jørund";
    }
}

public class Point
{
    public int X;
    public int Y;

    public Point()
    {
        
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // En metodes signatur er hvilke parametere den tar
    // Her er en signatur for Move metoden
    public void Move(int xDirection, int yDirection)
    {
        X += xDirection;
        Y += yDirection;
    }

    // Og her er en annen signatur for Move metoden
    // Antall signaturer er altså det samme som
    // antallet overloads
    // Første overloaden beveget punktet en viss avstand
    // og retning først i x-aksen, og deretter i y-aksen.
    // Følgende signatur tar bare inn et punkt, 
    // og flytter nåværende punkt dit. Med andre ord
    // en destinasjon.

    // I denne varianten følger man samme logikk som i signaturen ovenfor
    // Man kopierer altså kode, som er unødvendig
    // public void Move(Point destination)
    // {
    //     this.X = destination.X;
    //     this.Y = destination.Y;
    // }

    // Dette er en bedre versjon som gjør det samme
    // (jeg tok feil ovenfor, i første metode brukte jeg +=, og 
    // i denne signaturen brukte jeg kun =, dermed omgjøres dette
    // nå om til en type Move funksjon som flytter punktet 
    // med så og så mye i en x og y retning, altså noe helt annet)
    public void Move(Point destination)
    {
        if(destination == null)
            throw new ArgumentNullException("destination"); // Dette er ikke en melding til bruker, men forteller om hvilket argument det gjelder
        Move(destination.X, destination.Y);
    }
}
public static class Methods
{
    public static void Run()
    {
        // Man bruker det han kaller globale exception handlers for hele 'programmet'
        // og så legger man inn exceptions der det kan krasje (i stedet for mange try/catch blokker overalt)
        try
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
        catch(Exception)
        {
            Console.WriteLine("En uventet feil skjedde");
        }


    }
}
