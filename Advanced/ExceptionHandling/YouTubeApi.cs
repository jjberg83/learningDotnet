using Advanced.EventsAndDelegates;

namespace Advanced.ExceptionHandling;

public class YouTubeApi
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            // Access YouTube web services
            // Read the data
            // Create a list of Video objects

            // Nå simulerer vi at noe gikk galt med noen av punktene over
            throw new Exception("Oi, shit, noe gikk galt dypt nede i mørket som er YouTube APIet");
        }
        catch (Exception e)
        {
            // Her gir man en mer intuitiv beskjed hvis noe går galt, enn en asbergers aktig feil dypt nede i YouTube APIet
            // Vil man lete mer spesifikt, har vi jo den originale exceptionen lagret i e.
            throw new YouTubeException("Noe gikk galt med YouTubeAPIet", e);
        }
        return new List<Video>();
    }
}
