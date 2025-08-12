namespace Advanced.EventsAndDelegates;

public class MailService
{
    // Denne metoden må følge signaturen til delegaten i VideoEncoder
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("Sending EMAIL");
    }
}