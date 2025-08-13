namespace Advanced.EventsAndDelegates;

// Versjon_1: Der vi bruker en custom delegate (som egentlig er)
// public class EventsAndDelegates
// {
//     public static void Run()
//     {
//         var theQuickAndTheDead = new Video() { Title = "The Quick And The Dead" };
//         var encoder = new VideoEncoder(); // publisher
//         var mailService = new MailService(); // subsriber
//         var smsService = new SmsService(); // subsriber
//         var notificationService = new NotificationService(); // subsriber
//         encoder.VideoEncoded += mailService.OnVideoEncoded; // her legger vi til mailservice på listen over subscribers
//         encoder.VideoEncoded += smsService.OnVideoEncoded; // her legger vi til smsservice på listen over subscribers
//         encoder.VideoEncoded += notificationService.OnVideoEncoded; // her legger vi til notificationservice på listen over subscribers
//         encoder.Encode(theQuickAndTheDead);
//     }
// }

// Versjon_2: Der vi bruker en derived class av EventArgs for å gi mer info
public class EventsAndDelegates
{
    public static void Run()
    {
        var theQuickAndTheDead = new Video() { Title = "The Quick And The Dead" };
        var waterWorld = new Video() { Title = "Waterworld" };
        var encoder = new VideoEncoder(); // publisher
        var mailService = new MailService(); // subsriber
        var smsService = new SmsService(); // subsriber
        var notificationService = new NotificationService(); // subsriber
        encoder.VideoEncoded += mailService.OnVideoEncoded; // her legger vi til mailservice på listen over subscribers
        encoder.VideoEncoded += smsService.OnVideoEncoded; // her legger vi til smsservice på listen over subscribers
        encoder.VideoEncoded += notificationService.OnVideoEncoded; // her legger vi til notificationservice på listen over subscribers
        encoder.Encode(theQuickAndTheDead);
        encoder.Encode(waterWorld);
    }
}
