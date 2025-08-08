namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates;

internal class Canvas
{
    public void Draw(Action<Shape> myDelegate)
    {
        Shape shape = Shape.Load();

        myDelegate(shape);
    }
    // public void Draw(List<Shape> shapes)
    // {
    //     foreach (var shape in shapes)
    //     {
    //         shape.Draw();
    //     }
    // }
}
