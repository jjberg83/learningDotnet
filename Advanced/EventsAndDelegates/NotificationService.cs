namespace Advanced.EventsAndDelegates;

public class NotificationService
{
    public void OnVideoEncoded(object source, VideoEventArgs videoArgs)
    {
        // Nå kan vi gi info om hvilken film som har blitt encoded!
        Console.WriteLine($"Sending NOTIFICATION, the video titled {videoArgs.Video.Title} has been encoded");
    }
}
