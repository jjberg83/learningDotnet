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
    // Er da mulig å nå herfra i metoder og fields, men ikke i konstruktøren.

    // Github copilot ga gode svar på hvorfor det under ikke funket
    /*
    The issue lies in how constructors work in C#. Even though _registrationNumber is now protected in the Vehicle class, 
    the Car constructor cannot directly initialize it because constructors in derived classes cannot bypass the base class 
    constructor's responsibility for initializing its fields.

    Key Points:
    Protected Access:

    The protected modifier allows the Car class to access _registrationNumber in methods or properties.
    However, constructors are special because they are responsible for initializing the base class's fields. This responsibility cannot 
    be overridden by the derived class.
    Why It Fails:

    In the Car constructor, you are trying to set _registrationNumber directly:
    This fails because _registrationNumber is a field of the Vehicle class, and the Vehicle constructor is responsible for initializing it. 
    The derived class cannot take over this responsibility.
    */

    // public Car(string registrationNumber)
    // {
    //     SetRegistrationNumber(registrationNumber);
    // }

    // public void SetRegistrationNumber(string registrationNumber)
    // {
    //     _registrationNumber = registrationNumber;

    // }

    
}
