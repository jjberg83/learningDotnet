namespace Intermediate.Polymorphism;

internal class Animal
{
    public DateTime Birthday { get; set; }

    // Virtual gjør at denne metoden kan overrides av derived klassens
    // forslag til implementasjon av denne metoden (med akkurat samme signatur)
    public virtual void Eat()
    {
        Console.WriteLine("Eat food as fast as possible before other animals take my food");
    }

    public void Sleep()
    {
        Console.WriteLine("Jeg sover med ett øye åpent");
    }

}
