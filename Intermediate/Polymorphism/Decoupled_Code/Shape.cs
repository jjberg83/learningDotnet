namespace Intermediate.Polymorphism.Decoupled_Code;

internal class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Draw a SHAPE");
    }
}