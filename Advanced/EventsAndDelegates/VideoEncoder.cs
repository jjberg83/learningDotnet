namespace Advanced.EventsAndDelegates;

// Stegene for å bruke delegate med events
// 1 - Define a delegate
// 2 - Define an event based on that delegate
// 3 - Raise the event

// Versjon_1: Der man lager en custom delegate (som egentlig er unødvendig)
// public class VideoEncoder
// {

//     // Steg 1
//     // Standard å legge til EventHandler til slutt i delegate navnet
//     // Denne signaturen må metodene i subscribers følge
//     public delegate void VideoEncodedEventHandler(object source, EventArgs args);

//     // Steg 2
//     public event VideoEncodedEventHandler VideoEncoded;
//     public void Encode(Video video)
//     {
//         Console.WriteLine("Encoding video...");
//         Thread.Sleep(3000);

//         // Steg 3
//         OnVideoEncoded();
//     }


//     // Konvensjon at EventPublisher methods skal være protected, virtual og void
//     // Navn skal være On<EventNavn>
//     // Denne metoden skal gi beskjed til alle subscribers (siden vi nå er i publisher klassen)
//     protected virtual void OnVideoEncoded()
//     {
//         // Først må vi sjekke at det faktisk er subscribers til eventen
//         if (VideoEncoded != null)
//             // Her gir vi beskjed til alle subsribers
//             // Siden source er denne klassen brukes this, og siden vi ikke vil legge til info bruker vi EventArgs.Empty
//             VideoEncoded(this, EventArgs.Empty);
//     }
// }

// Versjon_2: Der vi lager en klasse VideoEventArgs som inneholder
// data om Videoen som ble encodet
public class VideoEncoder
{
    // Legg merket til at vi nå bruker den nye klassen VideoEventArgs, 
    // som er derived fra base class EventArgs
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    public event VideoEncodedEventHandler VideoEncoded;
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        // Legg merke til at vi legger inn videoen som argument her
        OnVideoEncoded(video);
    }


    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
            // Her ønsker vi i motsetning til før å legge til info,
            // og dermed bruker vi den nye VideoEventArgs klassen her
            VideoEncoded(this, new VideoEventArgs() { Video = video });
    }
}
