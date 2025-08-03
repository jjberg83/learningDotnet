namespace Intermediate.Polymorphism.Decoupled_Code_With_Interfaces;

internal interface IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }
    void Draw();
}