namespace Intermediate.Polymorphism;
internal class Animal
{
    private readonly DateTime _birthDate;

    public Animal(DateTime birthDate)
    {
        _birthDate = birthDate;
    }

    // Virtual gjør at denne metoden kan overrides av derived klassens
    // forslag til implementasjon av denne metoden (med akkurat samme signatur)
    public virtual void Eat()
    {
        Console.WriteLine("Eat food as fast as possible before other animals take my food");
    }

}
