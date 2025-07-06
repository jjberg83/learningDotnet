namespace Intermediate.Interfaces;

public class SMSService : INotifier
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending sms...");
    }
}
