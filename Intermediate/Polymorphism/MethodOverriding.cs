namespace Intermediate.Polymorphism;
internal class MethodOverriding
{
    public static void Run()
    {
        // Polymorphism betyr poly=mange morph=former

        // Før har jeg lært om Overloading, som er metoder med samme navn, 
        // men forskjellig signatur (altså argumenter)

        // Overriding er metoder med samme navn OG signatur, men
        // som har forskjellige implementasjoner
        // Typisk brukstilfelle er derived classes som ønsker
        // sine egne implementasjoner av metoder som passer bedre 
        // i settingen derived class opererer

        // Først prøver jeg meg på et eksempel selv, så kommer
        // instruktørens eksempel etterpå

        // To måter å sette bursdagen til Animal objekter/instanser
        var dog = new Animal();
        dog.Birthday = new DateTime(2018, 02, 15);
        var cat = new Animal() { Birthday = new DateTime(2023, 08, 14) };

        // Vi ser at Human også når Birthday propertien fra base klassen Animal på samme måter
        var jørund = new Human();
        jørund.Birthday = new DateTime(1983, 07, 02);
        var lori = new Human() { Birthday = new DateTime(1985, 04, 19) };

        List<Animal> animals = new List<Animal> { dog, cat, jørund, lori };

        foreach (var animal in animals)
        {
            Console.WriteLine($"Jeg ble født {animal.Birthday}");
            // Her ser man at Human klassens Eat metode legger til ekstra oppå Anmial klassens Eat metode
            // Denne foreach blokken trenger ikke endres. Vi bare kaller på metoden, så vet foreach
            // blokken om det er snakk om base class eller en derived class, og henter det som er 
            // ekstra i Eat klassen hvis det er snakk om en derived class
            animal.Eat();
            Console.WriteLine("---------------------------");
        }
        
    }
}
