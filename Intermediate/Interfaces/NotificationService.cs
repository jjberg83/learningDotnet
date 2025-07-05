namespace Intermediate.Interfaces;

public class NotificationService : INotifier
{
    public void Send()
    {
        Console.WriteLine("Sending notification...");
    }
}
