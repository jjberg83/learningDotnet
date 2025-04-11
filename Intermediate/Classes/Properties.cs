namespace Intermediate.Classes;

public class Properties
{
    public static void Run()
    {
        // Properties brukes for å skape getters/setters med mindre kode
        // Men koden under som virket uten properties må endres
        // var person1 = new PersonPrivat();
        // DateTime bursdag = new DateTime(1983, 07, 02);
        // Console.WriteLine(person1.GetBirthdate()); 
        // person1.SetBirthdate(bursdag);
        // Console.WriteLine(person1.GetBirthdate()); 

        // Kode som må til når man har en default property (ved å bruke "prop" code snippeten)
        // var lori = new PersonPrivat();
        // DateTime bursdag = new DateTime(1985, 04, 19);
        // Console.WriteLine(lori.BirthDate); 
        // lori.BirthDate = bursdag;
        // Console.WriteLine(lori.BirthDate); 

        // Kode som må til når man har property med private foran setteren
        // BirthDate kan da bare defineres i constructoren
        var person1 = new PersonPrivat(new DateTime(1983, 07, 02));
        Console.WriteLine(person1.BirthDate); 

        // Han anbefaler Productivity Power Tools 
        // Antageligvis legacy?
        // Når man høyreklikker på project skal man få valget "Open Command Prompt"
        // Unødvendig verktøy, var bare for å komme rett inn på prosjektet i Terminalen
        // Han ville vise koden som ble skapt for klassen under panseret, men ser ut til 
        // at det er forskjellig for Windows og Mac. Han gikk til bin > Debug, og her åpnet han
        // Properties.exe. Antageligvis dll fil for meg
        // Han skriver så "ildasm Intermediate.exe" (ildasm er intermediate language disasembler)

        // Jeg installerte ilspycmd i stedet for (for å se IL koden)
        // Gå til bin > Debug > net.9.0, og skriv kommandoen
        // ilspycmd Intermediate.dll
        // Virket ikke slik han viste. Poenget var at i IL koden så man at en default constructor
        // ble skapt, og at et privat Birthday field, med en egen getter og setter også
        // ble skapt, selv om vi bare skrev en public Property i PersonPrivate klassen.

        var jørund = new PersonPrivat(new DateTime(1983, 07, 02));
        Console.WriteLine(jørund.BirthDate);
        Console.WriteLine(jørund.Age);
        Console.WriteLine(jørund.Name);
        Console.WriteLine(jørund.UserName);
        jørund.Name = "Jørund Jenssen Berg";
        jørund.UserName = "rrttløljf";
        Console.WriteLine(jørund.Name);
        Console.WriteLine(jørund.UserName);

        
    }
}
