namespace Intermediate.Classes;

// Gjorde klassen statisk, såkalt "utility class". Copilot sier følgende om fordelene:

// A static (utility) class is used when you want to group related methods that do not require object state. 
//These methods typically perform operations, calculations, or helper tasks and do not need to store data between calls.

// Benefits of a static utility class:
// You cannot create instances of the class, so it saves memory and prevents misuse.
// All methods are static and can be called directly: Calculator.Add(1, 2, 3).
// It organizes code and makes it clear that the class is only for functionality, not for representing objects or data.
// Typical use cases: math operations, string manipulation, conversions, or other helper functions.
public static class Calculator
{
    // Uten params kan man ikke kalle på metoden som man gjør i variabelen add5 og add6
    // public static int Add(int[] numbers)
    public static int Add(params int[] numbers)
    {
        int result = 0;
        foreach (int n in numbers)
        {
            result += n;
        }
        return result;
    }
}
