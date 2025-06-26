namespace Intermediate.Interfaces;
public class UiControl
{
    public int Id { get; set; }
    public Size Size { get; set; }
    public Position TopLeft { get; set; }
    public virtual void Draw()
    {

    }

    public void Focus()
    {
        Console.WriteLine("Received focus");
    }
}
