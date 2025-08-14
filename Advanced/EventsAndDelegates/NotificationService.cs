namespace Advanced.EventsAndDelegates;

public class NotificationService
{
    // Uten argumenter i EventArgs
    public void OnVideoEncoded(object source, EventArgs args)
    {
        Console.WriteLine($"Sending NOTIFICATION");
    }

    // Med argumenter i EventArgs
    // public void OnVideoEncoded(object source, VideoEventArgs videoArgs)
    // {
    //     // Nå kan vi gi info om hvilken film som har blitt encoded!
    //     Console.WriteLine($"Sending NOTIFICATION, the video titled {videoArgs.Video.Title} has been encoded");
    // }
}
