namespace Intermediate.Inheritance;
internal class UpcastingAndDowncasting
{
    public static void Run()
    {
        Text text = new Text();
        // Her upcaster vi, det skjer implisitt. Begge disse to peker til samme plass i minne.
        // Men når man bruker base class får man ikke tak i derived class
        // sine fields og metoder.Man sier at de peker til samme plass i minnet, de har samme
        // referanse, men de har forskjellige views (altså at man ikke får tak i derived
        // klassens fields og metoder når man har en base class)
        Shape shape = text;

        text.Width = 100;
        shape.Width = 200;
        Console.WriteLine(text.Width); // Vil vise 200 siden de begge endrer samme referanse

        // StreamReader brukes for å lese data fra enhver kilde i C#
        StreamReader reader = new StreamReader(MemoryStream stream);
        

    }
    
}
