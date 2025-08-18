namespace Shared;

public static class CoderExtensionsShared
{
    public static void Reverse(this CoderShared coder)
    {
        var words = coder.Strenghts.Split(" ").Reverse();
        Console.WriteLine(string.Join(" ", words));
    }
}

