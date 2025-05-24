namespace Intermediate.Polymorphism;
internal class AbstractClassesAndMembers
{
    public static void Run()
    {
        // Abstract i klasser og metoder betyr egentlig at base class har en metode
        // som implisitt har virtual foran, men ikke implementeres i det hele tatt
        // i base class, men alltid i derived class. Med andre ord, hvis en base
        // class er abstract har den iallefall en virtual metode som ikke har noen implementasjon
        // men som har det i klassene som arver fra denne. Eksempelet fra Decoupled_Code 
        // blir da som det du ser under.

        // Det følger med en del regler for bruken av abstract:
        // 1 - I base class skal man ikke implementere metoden (har ikke curly braces en gang)
        // 2 - Er en member av en klasse abstract, må hele klassen defineres som abstract (base class altså)
        // 3 - Derived classes må implementere ALLE abstract members fra base class den arver fra (slik tvinger man andre utviklere til å følge blue printen fra base class)
        // 4 - Abstract klasser kan ikke instansierers, altså nytter ikke dette -> var shape = new Shape(); Det vil gi feilmelding

        // Poenget med abstract base classes er at de skal gjøre at derived classes må følge et mønster med 
        // felles metoder. Men base class er for abstrakt, sett fra et konseptuelt ståsted. Hva betyr for eksempel shape her? Hvilken shape?
        // En shape er det som er felles for alle sirkler, firkanter, trekanter osv. Det er en abstract ide, ikke noe man kan konkret implementere
        // (eller i kode instansiere). En shape er felles oppførsel og kjennetegn. En abstrakt ting.

        var sirkel = new Circle();
        Square firkant = new();

        var shapes = new List<Shape> { sirkel, firkant };

        var canvas = new Canvas();
        canvas.Draw(shapes);
    }
}