namespace Advanced.EventsAndDelegates;

public class VideoEncoder
{
    // Stegene for å bruke delegate med events
    // 1 - Define a delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise the event

    // Steg 1
    // Standard å legge til EventHandler til slutt i delegate navnet
    public delegate void VideoEncodedEventHandler(object source, EventArgs args);

    // Steg 2
    public event VideoEncodedEventHandler VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        // Steg 3
        OnVideoEncoded();
    }


    // Konvensjon at EventPublisher methods skal være protected, virtual og void
    // Navn skal være On<EventNavn>
    // Denne metoden skal gi beskjed til alle subscribers (siden vi nå er i publisher klassen)
    protected virtual void OnVideoEncoded()
    {
        // Først må vi sjekke at det faktisk er subscribers til eventen
        if (VideoEncoded != null)
            // Her gir vi beskjed til alle subsribers
            // Siden source er denne klassen brukes this, og siden vi ikke vil legge til info bruker vi EventArgs.Empty
            VideoEncoded(this, EventArgs.Empty);
    }
}
