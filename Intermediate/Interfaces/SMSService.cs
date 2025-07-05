namespace Intermediate.Interfaces;

public class SMSService : INotifier
{
    public void Send()
    {
        Console.WriteLine("Sending sms...");
    }
}
