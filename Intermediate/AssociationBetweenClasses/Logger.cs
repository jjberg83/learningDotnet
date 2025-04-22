namespace Intermediate.AssociationBetweenClasses;

public class Logger
{
    public DateTime CreationTime { get; set; }

    public DateTime DeletionTime
    { 
        get; 
        set;
    }    

    public Logger()
    {
        DeletionTime = new DateTime(1984, 07,02);
    }
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
