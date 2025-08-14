namespace Advanced.EventsAndDelegates;

public class SmsService
{
    // Uten argumenter i EventArgs
    public void OnVideoEncoded(object source, EventArgs args)
    {
        Console.WriteLine($"Sending SMS");
    }
    // Med argumenter i EventArgs
    // public void OnVideoEncoded(object source, VideoEventArgs videoArgs)
    // {
    //     // Nå kan vi gi info om hvilken film som har blitt encoded!
    //     Console.WriteLine($"Sending SMS, the video titled {videoArgs.Video.Title} has been encoded");
    // }
}
