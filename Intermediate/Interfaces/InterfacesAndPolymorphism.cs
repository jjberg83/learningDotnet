using System.Reflection.PortableExecutable;

namespace Intermediate.Interfaces;
public class InterfacesAndPolymorphism
{
    public static void Run()
    {
        var mailService = new Encoder(new MailService());
        mailService.Encode(new Video());
        Console.WriteLine("-----------------");

        var smsService = new Encoder(new SMSService());
        smsService.Encode(new Video());
        Console.WriteLine("-----------------");


        var notificationService = new Encoder(new NotificationService());
        notificationService.Encode(new Video());
        Console.WriteLine("-----------------");

    }
}