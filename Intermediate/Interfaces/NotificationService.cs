namespace Intermediate.Interfaces;

public class NotificationService : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Sending notification...");
        Console.WriteLine("Content: ");
        Console.WriteLine(message);
    }
}
