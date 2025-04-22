namespace Intermediate.AssociationBetweenClasses;
public class Gathering
{
    public DateTime StartTime { get; set; }   
    public DateTime EndTime { get; set; }   

    public void Statement(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine($"StartTime: {StartTime}");
        Console.WriteLine($"EndTime: {EndTime}");
    }
}
