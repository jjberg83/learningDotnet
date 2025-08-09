namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates_Action;

internal class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    public static void Draw()
    {
        Console.WriteLine("Draw a SHAPE");
    }
}