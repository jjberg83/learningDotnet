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

    
    
}
