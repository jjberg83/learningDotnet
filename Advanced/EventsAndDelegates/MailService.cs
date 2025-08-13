namespace Advanced.EventsAndDelegates;

public class MailService
{
    // Denne metoden må følge signaturen til delegaten i VideoEncoder
    public void OnVideoEncoded(object source, VideoEventArgs videoArgs)
    {
        // Nå kan vi gi info om hvilken film som har blitt encoded!
        Console.WriteLine($"Sending EMAIL, the video titled {videoArgs.Video.Title} has been encoded");
    }
}