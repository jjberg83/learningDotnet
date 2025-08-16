using Intermediate.Classes;

namespace Advanced.ExtensionMethods;

public static class CoderExtensions
{
    public static void Reverse(this Coder coder)
    {
        var words = coder.Strenghts.Split(" ").Reverse();
        Console.WriteLine(string.Join(" ", words));
    }
}

