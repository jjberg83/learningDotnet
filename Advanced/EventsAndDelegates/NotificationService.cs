namespace Advanced.EventsAndDelegates;

public class NotificationService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Sending NOTIFICATION");
    }
}
