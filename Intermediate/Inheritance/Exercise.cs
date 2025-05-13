using System.Runtime.InteropServices;

namespace Intermediate.Inheritance;

internal class Exercise
{
    public static void Run()
    {
        var stack = new Stack();
        int ini = 1;
        int max = 5;

        for(int i = ini; i <= max; i++)
        {
            stack.Push(i);
        }
        for(int i = ini; i <= max; i++)
        {
            Console.WriteLine(stack.Pop()); 
        }
        // stack.Push(1);
        // stack.Push(2);
        // stack.Push(3);
        // Console.WriteLine(stack.Pop()); // -> Bør gi 3
        // Console.WriteLine(stack.Pop());// -> Bør gi 2
        // Console.WriteLine(stack.Pop());// -> Bør gi 1

        // Should fail
        stack.Push(null);
    } 
}
