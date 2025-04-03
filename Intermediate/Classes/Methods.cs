namespace Intermediate.Classes;

public static class Calculator
{
    // Uten params kan man ikke kalle på metoden som man gjør i variabelen add5
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
public static class Methods
{
    public static void Run()
    {
        // Man kan legge inn et varierende antall parametere til metoden
        int add3 = Calculator.Add(new int[]{1,2,3});
        int add4 = Calculator.Add(new int[]{1,2,3,4});
        int add5 = Calculator.Add(1,2,3,4,5);
        Console.WriteLine(add3);
        Console.WriteLine(add4);
        Console.WriteLine(add5);
    }
}
