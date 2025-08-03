using Intermediate.Polymorphism.Decoupled_Code_With_Inheritance;

namespace Intermediate.Polymorphism;
internal abstract class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    // Ingen curly braces eller implementasjon her
    public abstract void Draw();
}
