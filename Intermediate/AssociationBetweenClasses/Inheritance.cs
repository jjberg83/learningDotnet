namespace Intermediate.AssociationBetweenClasses;

public class Inheritance
{
    public static void Run()
    {
        Text myFirstText = new Text();
        myFirstText.TextContent = "Hei, dette er min første tekst";

        // Over brukte jeg kun det som var definert eksplisitt i parent class
        // Under bruker jeg det Text klassen arver fra parenten PresentationObject
        myFirstText.Width = 18;
        Console.WriteLine(myFirstText.Width);
        myFirstText.Copy();
    }
}