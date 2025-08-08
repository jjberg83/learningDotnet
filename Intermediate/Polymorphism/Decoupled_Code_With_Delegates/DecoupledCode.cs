namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates;

internal class DecoupledCode
{
    public static void Run()
    {
        var sirkel = new Circle() { Position = new Position() { Y = 2 } };
        sirkel.Position.X = 5;

        var firkant = new Square();
        var trekant = new Triangle();

        // Vi trenger ikke instansene over, kan jo eventuelt gjøre metodene statiske
        // Tror hemmeligheten blir å lage en delegate i stedet for denne listen
        // Så kan vi kjøre Draw metoden med forskjellige Action delegates, og se at de henter
        // inn og kjører forskjellige metoder (noen fra square, noen fra cirlce osv)
        // Vi kan gjøre dette både med inheritance, interfaces og også uten noen av de om vi vil.

        // var shapes = new List<Shape>() { sirkel, firkant, trekant };

        var canvas = new Canvas();
        // canvas.Draw(shapes);

        Action<Shape> myFirstDelegate = methodInMain;
        myFirstDelegate += sirkel.Draw;

        canvas.Draw(myFirstDelegate);
    }

    public static void methodInMain(Shape shape)
    {
        Console.WriteLine("Draw something...");
    }
}