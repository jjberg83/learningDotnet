namespace Intermediate.Polymorphism;

internal class Canvas
{
    public void Draw(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
