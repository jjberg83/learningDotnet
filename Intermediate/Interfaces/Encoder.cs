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
// public class Encoder
// {
//     private readonly INotifier _notifier;

//     public Encoder(INotifier notifier)
//     {
//         _notifier = notifier;
//     }

//     public void Encode(Video video)
//     {
//         // Video encode logic
//         _notifier.Send($"Video has been encoded at {DateTime.Now}");
//     }
// }

// Problemet med min variant over er at vi må lage flere Encodere hvis vi 
// har lyst til å gi beskjed på flere måter (sms, mail, notification osv).
// I tillegg til å ha flere Encodere for hver måte å gi beskjed på, vil også
// en Video bli encodet for hver Encoder. Masse sløsing av ressursen.
// Nedenfor er det jeg trodde ville bli instruktørens løsning der man kun lager EN Encoder, man encoder 
// bare EN video, men man gir beskjed om det på flere forskjellige måter.

// public class Encoder
// {
//     private readonly IList<INotifier> _notifiers;

//     public Encoder(IList<INotifier> notifiers)
//     {
//         _notifiers = notifiers;
//     }

//     public void Encode()
//     {
//         foreach (INotifier notification in _notifiers)
//         {
//             notification.Send();
//             Console.WriteLine($"Video has been encoded at {DateTime.Now}");
//         }
//     }
// }

// Her kommer endelig løsning fra instruktøren. Han lager ny tom liste i konstruktøren.
// Siden fieldet er privat og readonly kan det bare skapes en gang, enten i fieldet
// selv, eller i konstruktøren. Men det hindrer oss ikke i å legge til eller fjerne
// elementer fra det. Men siden fieldet er privat, må vi lage en egen metode for å legge til, 
// og en egen metode for å trekke fra INotifiers.

public class Encoder
{
    private readonly IList<INotifier> _notifiers;

    public Encoder()
    {
        _notifiers = new List<INotifier>() { };
    }

    public void Encode()
    {
        if (_notifiers.Count == 0)
            Console.WriteLine("Encoder does not contain any notifiers (sms, email, notification etc)");
            
        foreach (INotifier notifier in _notifiers)
        {
            notifier.Send(new Message());
            Console.WriteLine($"Video has been encoded at {DateTime.Now}");
        }
    }

    public void AddNotifier(INotifier notifier)
    {
        _notifiers.Add(notifier);
    }

    public void RemoveNotifier(int index)
    {
        _notifiers.RemoveAt(index);
    }
}
