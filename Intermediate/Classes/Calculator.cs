namespace Intermediate.Classes;

// Gjorde klassen statisk, såkalt "utility class"
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
