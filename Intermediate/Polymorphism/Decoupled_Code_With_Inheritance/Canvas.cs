namespace Intermediate.Polymorphism.Decoupled_Code_With_Inheritance;
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
