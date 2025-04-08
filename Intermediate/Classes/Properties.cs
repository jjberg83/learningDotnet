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

        // Endres til
        var person1 = new PersonPrivat();
        DateTime bursdag = new DateTime(1983, 07, 02);
        Console.WriteLine(person1.BirthDate); 
        person1.BirthDate = bursdag;
        Console.WriteLine(person1.BirthDate); 

        // Han anbefaler Productivity Power Tools 
        // Antageligvis legacy?
        // Når man høyreklikker på project skal man få valget "Open Command Prompt"
        // Unødvendig verktøy, var bare for å komme rett inn på prosjektet i Terminalen
        // Han ville vise koden som ble skapt for klassen under panseret, men ser ut til 
        // at det er forskjellig for Windows og Mac. Han gikk til bin > Debug, og her åpnet han
        // Properties.exe. Antageligvis dll fil for meg
        // Han skriver så "ildasm Intermediate.exe" (ildasm er intermediate language disasembler)

        
    }
}
