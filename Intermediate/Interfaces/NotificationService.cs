namespace Intermediate.Interfaces;

public class NotificationService : INotifier
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending notification...");
    }
}
