namespace Advanced.ExtensionMethods;

public static class StringExtensions
{
    public static string Shorten(this String message, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("numberOfWords argumentet må være 0 eller større");

        if (numberOfWords == 0)
            return "";

        var words = message.Split(" ");

        if (words.Length <= numberOfWords)
            return message;

        // Take er en extension method
        return string.Join(" ", words.Take(numberOfWords));
    }
}

