namespace Intermediate.Polymorphism.Decoupled_Code_With_Interfaces;

internal class Triangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }
    public void Draw()
    {
        Console.WriteLine("Draw a TRIANGLE");
    }
}
