using System.Security.Cryptography.X509Certificates;

namespace Intermediate.Classes;

public class IntroductionToClasses
{
    public static void Run()
    {
        var person = new Person(); // Når parse metoden ikke er statisk, må det finnes en Gud
        var jørund = person.Parse("Jørund");
        jørund.Introduce("Lori");

        person.Introduce(jørund.Name); //første person har ikke navn

        person.Name = "God"; 

        // Nå er opprinnelig person endret. Har vi begge hvert vårt navn?

        person.Introduce(jørund.Name);
        jørund.Introduce(person.Name);

        // Og hvis ingenting skjer med Gud nå, vet jeg at Parse metoden skaper et
        // uavhengig objekt/instans som peker til en annen plass i minnet

        jørund.Name = "Jørund Jenssen Berg";

        person.Introduce(jørund.Name);
        jørund.Introduce(person.Name);

        // Hadde metoden Parse vært statisk, kunne jeg skrevet koden slik
        // (jeg hadde ikke trengt å opprette Gud)
        // Fordelen med constutors er at man slipper å skrive noe 
        // etter Person.EnEllerAnnenConstructorLookALike("Navn")
        // var Audun = Person.Parse("Audun"); 
        // Audun.Introduce("Vanessa");


        
    }
}

public class Person
{
    public string Name;

    public void Introduce(string to)
    {
        Console.WriteLine($"Hi {to}, I am {Name}");
    }

    // Han viser denne før han skal snakke om constructors
    // I koden over tester jeg for om det peker til samme plass i minnet som Personen det ble skapt inni
    public Person Parse(string name) 
    {
        var person = new Person();
        person.Name = name;
        return person;
    }
}