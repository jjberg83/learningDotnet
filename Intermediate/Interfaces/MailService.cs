namespace Intermediate.Interfaces;
public class MailService : INotifier
{
    public void Send()
    {
        Console.WriteLine("Sending email...");
    }
}
