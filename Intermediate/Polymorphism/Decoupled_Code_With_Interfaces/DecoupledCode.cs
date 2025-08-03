namespace Intermediate.Polymorphism.Decoupled_Code_With_Interfaces;
internal class DecoupledCode
{
    public static void Run()
    {
        var sirkel = new Circle() { Position = new Position() { Y = 2 } };
        sirkel.Position.X = 5;

        var firkant = new Square();
        var trekant = new Triangle();

        var shapes = new List<IShape>() { sirkel, firkant, trekant };

        var canvas = new Canvas();
        canvas.Draw(shapes);
    }
}