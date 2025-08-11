namespace Advanced.EventsAndDelegates;

public class EventsAndDelegates
{
    public static void Run()
    {
        var theQuickAndTheDead = new Video() { Title = "The Quick And The Dead" };
        var encoder = new VideoEncoder();
        encoder.Encode(theQuickAndTheDead);

        // Nå skal han lage et par subscribers til Eventen i VideoEncoder (som er publisher klassen)
    }
}