namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates;

internal class Square : Shape
{
    public override void Draw(Shape shape)
    {
        Console.WriteLine("Draw a SQUARE");
    }
}
