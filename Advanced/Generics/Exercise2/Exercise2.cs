using System.Collections.Generic;
using System;

namespace Advanced.Generics.Exercise2;
/* 
Spurte Github Copilot om å gi meg oppgaver for å teste min forståelse av Generics i C#. 
Her er andre oppgave.

Exercise 2: Generic Stack Class
Implement a generic Stack<T> class with the following methods:

void Push(T item)
T Pop()
T Peek()
int Count { get; }
Do not use the built-in Stack<T> from .NET.
*/
public class Exercise2
{
    public static void Run()
    {
        var intStack = new Stack<int>();
        // Console.WriteLine($"intStack.Pop(): {intStack.Pop()}");
        // Console.WriteLine($"intStack.Peek(): {intStack.Peek()}");
        intStack.Push(42);
        intStack.Push(40);
        intStack.Push(5);
        intStack.Push(2);
        Console.WriteLine($"intStack.Peek(): {intStack.Peek()}");
        Console.WriteLine($"Antall elementer i stack: {intStack.Count}");
        Console.WriteLine($"intStack.Pop(): {intStack.Pop()}");
        Console.WriteLine($"Antall elementer i stack: {intStack.Count}");
        intStack.Pop();
        intStack.Pop();
        intStack.Pop();
        Console.WriteLine($"Antall elementer i stack: {intStack.Count}");
        // Console.WriteLine($"intStack.Pop(): {intStack.Pop()}");
        // Console.WriteLine($"intStack.Peek(): {intStack.Peek()}");

        var stringStack = new Stack<string>();
        // Console.WriteLine($"stringStack.Pop(): {stringStack.Pop()}");
        // Console.WriteLine($"stringStack.Peek(): {stringStack.Peek()}");
        stringStack.Push("Jørund");
        stringStack.Push("Lori");
        stringStack.Push("Elly");
        stringStack.Push("Marlene");
        Console.WriteLine($"stringStack.Peek(): {stringStack.Peek()}");
        Console.WriteLine($"Antall elementer i stack: {stringStack.Count}");
        Console.WriteLine($"stringStack.Pop(): {stringStack.Pop()}");
        Console.WriteLine($"Antall elementer i stack: {stringStack.Count}");
        stringStack.Pop();
        stringStack.Pop();
        stringStack.Pop();
        Console.WriteLine($"Antall elementer i stack: {stringStack.Count}");
        // Console.WriteLine($"stringStack.Pop(): {stringStack.Pop()}");
        // Console.WriteLine($"stringStack.Peek(): {stringStack.Peek()}");
        stringStack.Peek();
    }
}

