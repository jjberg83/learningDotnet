namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates_Custom;

internal class Canvas
{
    public delegate void ShapeDelegate();
    public void Draw(ShapeDelegate shapeDelegate)
    {
        shapeDelegate();
    }
}
