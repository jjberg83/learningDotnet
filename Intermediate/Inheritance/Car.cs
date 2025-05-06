namespace Intermediate.Inheritance;
internal class Car : Vehicle
{
    // Dette er ikke mulig, siden vi ikke har tilgang til det private fieldet
    // _registrationNumber i Vehicle klassen
    // public Car(string registrationNumber)
    // {
    //     _registrationNumber = registrationNumber;
    // }

    // Under baserer vi oss på at _registrationNumber er protected istedet for private. 
    // Protected gjør jo at fields og metoder fra parent class er tilgjengelig i derived classes.
    // Men, konstruktører er spesielle, fordi de skal gjøre objektene (en instans av en klasse) klare
    // i en viss tilstand. En derived klasses konstruktør kan aldri ta dette ansvaret fra parentens
    // konstruktør.

    // public Car(string registrationNumber)
    // {
    //     _registrationNumber = registrationNumber;
    // }

    // Men under ser du at man kan fortsatt sette fieldet når det er protected
    // (i en metode som vi alltid må i klasser hvis vi ikke gjør det når vi 
    // deklarerer et field øverst)

    public void SetRegistrationNumber(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }

    // Skal vi utnytte base klassens konstruktør, må vi gjøre slik
    // Base klassens konstruktør initialiserer vehicle klassens fields
    // som er dens ansvar. Car klassens konstruktør kaller bare på
    // base klassens konstruktør.
    public Car(string registrationNumber) : base(registrationNumber)
    {
        // Alt inni her må bare være relatert spesifikt for Car klassen.
    }
    
}
