namespace Intermediate.Inheritance;
internal class Vehicle
{
    protected string _registrationNumber;

    public Vehicle(string registrationNumber)
    {
        _registrationNumber = registrationNumber;
    }    

    public string GetRegistrationNumber()
    {
        return _registrationNumber;
    }
}
