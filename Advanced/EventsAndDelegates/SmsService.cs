namespace Advanced.EventsAndDelegates;

public class SmsService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Sending SMS");
    }
}
