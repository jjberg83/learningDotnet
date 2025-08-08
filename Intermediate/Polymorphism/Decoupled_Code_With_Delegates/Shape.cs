namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates;

internal class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    public static Shape Load()
    {
        return new Shape();
    }

    public virtual void Draw(Shape shape)
    {
        Console.WriteLine("Draw a SHAPE");
    }
}