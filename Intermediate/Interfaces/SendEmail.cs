namespace Intermediate.Interfaces;

public class SendEmail : IActivity
{
    public void Execute()
    {
        Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
    }
}