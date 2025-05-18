using System.Dynamic;

namespace Intermediate.Polymorphism.Coupled_Code;
internal class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }
    public ShapeType Type { get;  set; }
}