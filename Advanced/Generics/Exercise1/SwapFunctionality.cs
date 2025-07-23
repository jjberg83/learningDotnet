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

public class SwapFunctionality<T>
{

    internal static void Swap(ref T a, ref T b)
    {
        object aValue = a;
        object bValue = b;
        a = (T)bValue;
        b = (T)aValue;
    }
}

// Github Copilot godkjente løsningsforslaget mitt, men foreslo følgende:

// Trenger ikke box/unboxe, bruk heller følgende:
// T temp = a;
// a = b;
// b = temp;
