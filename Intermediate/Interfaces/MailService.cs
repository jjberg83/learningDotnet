namespace Intermediate.Interfaces;
public class MailService : INotifier
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending email...");
    }
}
