namespace Intermediate.Polymorphism.Coupled_Code;
internal class CoupledCode
{
    public static void Run()
    {
        var sirkel = new Shape() { Type = ShapeType.Circle, Position = new Position() {Y = 2} };
        sirkel.Position.X = 5;

        Console.WriteLine(sirkel.Position.X);
        Console.WriteLine(sirkel.Position.Y);
    
        var firkant = new Shape() { Type = ShapeType.Square };
        var trekant = new Shape() { Type = ShapeType.Triangle };
        // List<Shape> shapes = new List<Shape>() { sirkel, firkant }; // shortcuten

        // Eller den litt mer tungvindte måten å gjøre det samme på
        var shapes = new List<Shape>();
        shapes.Add(sirkel);
        shapes.Add(firkant);
        shapes.Add(trekant);

        // Problemet med coupled code er at hvis vi nå ønsker å legge til en Shape med et ny variant av fieldet Shape,
        // la oss si et triangel, må vi endre koden i to andre klasser, nemlig ShapeType og Canvas

        

        Canvas canvas = new Canvas();
        canvas.Draw(shapes);
    }
}