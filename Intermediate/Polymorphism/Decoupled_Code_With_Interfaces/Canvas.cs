namespace Intermediate.Polymorphism.Decoupled_Code_With_Interfaces;
internal class Canvas
{
    public void Draw(List<IShape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
