namespace Advanced.Generics.Exercise1;
/* 
Spurte Github Copilot om å gi meg oppgaver for å teste min forståelse av Generics i C#. 
Her er første oppgave.

Exercise 1: Generic Swap Method
Write a static generic method called Swap that takes two parameters by reference and swaps their values, regardless of type.

Example usage:

int a = 5, b = 10;
Swap(ref a, ref b); // a = 10, b = 5

string x = "hello", y = "world";
Swap(ref x, ref y); // x = "world", y = "hello"
*/
public class Exercise1
{
    public static void Run()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Write a static generic method called Swap that takes two parameters by reference and swaps their values, regardless of type.");
        Console.WriteLine("-----------------------");
        Console.WriteLine();
        Console.WriteLine("int a = 5, b = 10;");
        Console.WriteLine("Swap(ref a, ref b); // a = 10, b = 5");
        Console.WriteLine();
        int firstInt = 5;
        int secondInt = 10;
        Console.WriteLine($"firstInt: {firstInt}, secondInt: {secondInt}");
        SwapFunctionality<int>.Swap(ref firstInt, ref secondInt);
        Console.WriteLine($"firstInt: {firstInt}, secondInt: {secondInt}");

        string x = "hello", y = "world";
        Console.WriteLine($"x: {x}, y: {y}");
        SwapFunctionality<string>.Swap(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}");
    }
}

