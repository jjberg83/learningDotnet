namespace Intermediate.Classes;

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
    // med så og så mye i en x og y retning, altså noe helt annet.
    // Men med nærmere ettertanke burde begge overloadene gjøre
    // akkurat det samme. Gjør de forskjellige ting burde de
    // være ha forskjellige navn. Så gjør ikke dette om igjen.)
    public void Move(Point destination)
    {
        if(destination == null)
            throw new ArgumentNullException("destination"); // Dette er ikke en melding til bruker, men forteller om hvilket argument det gjelder
        Move(destination.X, destination.Y);
    }
}
