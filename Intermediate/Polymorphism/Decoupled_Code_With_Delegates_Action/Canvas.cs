namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates_Action;

internal class Canvas
{
    public void Draw(Action shapeDelegate)
    {
        shapeDelegate();
    }
}
