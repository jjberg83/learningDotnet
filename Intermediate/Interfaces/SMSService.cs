namespace Intermediate.Interfaces;

public class SMSService : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Sending sms...");
        Console.WriteLine("Content: ");
        Console.WriteLine(message);
    }
}
