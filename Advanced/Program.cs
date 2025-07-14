bool loopButton = true;
while (loopButton)
{
    Console.WriteLine("##################");
    Console.WriteLine("Skriv namespace.filnavn på det du vil kjøre (skriv stopp for å avslutte):");
    Console.WriteLine("##################");
    Console.WriteLine();

    string? userInput = Console.ReadLine();

    if (userInput != null && userInput.ToLower() == "stopp")
    {
        Console.WriteLine("Avslutter program...");
        break;
    }

    string className = $"Advanced.{userInput}";

    Type? type = Type.GetType(className);

    if (type != null)
    {
        var runMethod = type.GetMethod("Run", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        if (runMethod != null)
        {
            runMethod.Invoke(null, null);
        }
        else
        {
            Console.WriteLine($"Klassen '{userInput}' har ikke en statisk Run() metode.");
        }
    }
    else
    {
        Console.WriteLine($"Fant ingen klasse med navn '{userInput}.'");
    }
}

