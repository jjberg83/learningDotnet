namespace Intermediate.Polymorphism;

internal class Human : Animal
{
    public string? Nationality { get; set; }

    // Her bruker vi override for å kjøre en annen implementasjon av base klassens Eat funksjon
    // Poenget er at mennesker spiser mer sofistikert, men signatur er lik
    public override void Eat()
    {
        Console.WriteLine("Please tell me your name:");
        string? name = Console.ReadLine();
        Console.WriteLine($"Dear {name}, please dine with us. Here is a plate, fork and knife.");

        // Vi kan også kalle på base klassens Eat() metode, HVIS vi ønsker
        // Vi trenger ikke gjøre det, og vi kan kalle på den hvor vi vil inni denne metoden
        // base.Eat();
    }

    // Siden vi allerede har en metode kalt Sleep() i base class, og ikke bruker
    // virtual og override kombinasjonen, må vi skrive ekstra kode i for loopen i 
    // MethodOverriding.cs klassen for å kunne kalle på Human sin variant av Sleep metoden
    // (vi må sjekke for om Animal i hvert tilfelle også er en Human)
    public void Sleep()
    {
        Console.WriteLine("Jeg sover trygt i en seng og kan sove uforstyrret");
    }    
    
}
