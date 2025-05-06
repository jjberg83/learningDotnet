namespace Intermediate.Inheritance;
internal class ConstructorsAndInheritance
{
    public static void Run()
    {
        // Skaper man en instans av en derived klasse, kjøres alltid base klassens
        // konstruktør først, deretter derived klass sin konstruktør
        // (se bevis i cwene i konsollen)
        var myFirstHouse = new Hus();

        // Klasser lager kun tomme konstruktører under the hood hvis man
        // ikke har definert noen andre konstruktører heller
        // Derfor kan man ikke gjøre følgende:
        // Vehicle myFirstVehicle = new Vehicle();

        // I Car klassen får man ikke lov til å skrive en tom konstruktør,
        // fordi den er derived av Vehicle, og den har ikke en tom konstruktør
        // Car myFirstCar = new Car();

        // Man ender altså opp med at man må lage objekter av disse to klassene slik:
        Vehicle myFirstVehicle = new Vehicle("UFFDA342");
        Car myFirstCar = new Car("SÅNNJA78");
        Console.WriteLine(myFirstCar.GetRegistrationNumber());
        myFirstCar.SetRegistrationNumber("IKKENÅ83");
        Console.WriteLine(myFirstCar.GetRegistrationNumber());
    }
}