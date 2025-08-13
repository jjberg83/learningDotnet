namespace Advanced.EventsAndDelegates;

public class SmsService
{
    public void OnVideoEncoded(object source, VideoEventArgs videoArgs)
    {
        // Nå kan vi gi info om hvilken film som har blitt encoded!
        Console.WriteLine($"Sending SMS, the video titled {videoArgs.Video.Title} has been encoded");
    }
}
