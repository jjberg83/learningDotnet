namespace Intermediate.Interfaces;

public class ChangeStatus : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Change the status of the video record in the database to 'Processing'.");
    }
}