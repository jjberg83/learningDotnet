namespace Intermediate.Interfaces;

// Gammel logikk, der Encoder er avhengig av en konkret implementasjon (les: klasse)
// I dette tilfelle gir man beskjed om at videon er ferdig encoded via mail.
// Men hva om man i stedet for kan sende en sms? Eller notification på en app?

// public class Encoder
// {
//     private readonly MailService _mailService;
//     public Encoder()
//     {
//         _mailService = new MailService();
//     }
//     public void Encode(Video video)
//     {
//         // Encoding video logic
//         _mailService.Send(new Mail());
//     }
// }

// Bedre med en Encoder som er avhengig av et interface. 
// Da kan man endre Encoderens oppførsel bare med å skrive nye implementasjoner
// av interfacet INotifier.
public class Encoder
{
    private readonly INotifier _notifier;

    public Encoder(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Encode(Video video)
    {
        // Video encode logic
        _notifier.Send();
    }
}
