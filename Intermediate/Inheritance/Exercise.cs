namespace Intermediate.Inheritance;

internal class Exercise
{
    public static void Run()
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop()); // -> Bør gi 3
        Console.WriteLine(stack.Pop());// -> Bør gi 2
        Console.WriteLine(stack.Pop());// -> Bør gi 1
    } 
}
