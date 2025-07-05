using System.Reflection.PortableExecutable;

namespace Intermediate.Interfaces;
public class InterfacesAndPolymorphism
{
    public static void Run()
    {
        // Kode til mitt forslag for Encoder
        // Problemet med denne var at man måtte lage en ny Encoder
        // hver gang man ville varsle på en spesiell måte (SMS, Epost, notification etc).
        // I tillegg ville jo en video bli enkodet for hver av disse gangene. Masse sløsing.
        // var mailService = new Encoder(new MailService());
        // mailService.Encode(new Video());
        // Console.WriteLine("-----------------");

        // var smsService = new Encoder(new SMSService());
        // smsService.Encode(new Video());
        // Console.WriteLine("-----------------");


        // var notificationService = new Encoder(new NotificationService());
        // notificationService.Encode(new Video());
        // Console.WriteLine("-----------------");

        // Under er mitt forslag når instruktøren sa jeg skulle bruke en liste i stedet for.
        // Mitt forslag stemte ikke helt. Instruktørens forslag kommer nederst.
        // Vi legger til alle typer notifiers vi ønsker (dette kan variere per Encoder)
        List<INotifier> notifiersOne = new()
        {
            new SMSService(),
            new MailService(),
            new NotificationService()
        };
        Encoder encoderOne = new(notifiersOne);
        encoderOne.Encode();


        Console.WriteLine("-------------------");
        // I denne encoderen ønsker vi bare å varsle med SMS
        List<INotifier> notifiersTwo = new()
        {
            new SMSService()
        };
        Encoder encoderTwo = new(notifiersTwo);
        encoderTwo.Encode();

        // Nysgjerrig på hva som skjer hvis vi legger inn
        // notfiersTwo listen inn i objektet encoderOne. 
        // Her går det nok fordi vi overskriver instansen vi allerede
        // har av encoderOne. Man lager altså en ny Encoder, og sletter
        // gammel instans. 

        Console.WriteLine("--------------------");
        encoderOne = new(notifiersTwo);
        encoderOne.Encode();

        // Dette går ikke, fordi vi bruker allerede eksisterende instans av endoderOne.
        // Når vi bruker samme instans av encoderOne,
        // er jo listen der privat. Og man når den ikke fra utsiden.
        // I tillegg er den readonly, så man kunne bare lagt til og trukket
        // fra elementer i listen som allerede er skapt. Man kan ikke
        // slette gammel liste og legge inn ny instans.
        // encoderOne._notifers = notifiersTwo;

    }
}