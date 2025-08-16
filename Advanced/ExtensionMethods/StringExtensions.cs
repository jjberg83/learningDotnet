using System.Globalization;

namespace Advanced.ExtensionMethods;

public static class StringExtensions
{
    // Legg merke til første argument her, det er der man kjenner igjen at det er en extension method
    // Man arver ikke fra String klassen, men legger til en metode uten å endre koden i String klassen
    // this String message er altså instansen av en string, i dette tilfellet blogpost variabelen i ExtensionMethods.cs
    // Så kjennetegnet er at både klassen her og metodene er public static, og this <Class> som første argument
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
        return string.Join(" ", words.Take(numberOfWords)) + "...";
    }

    public static void CamelCase(this String message)
    {
        var words = message.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            if (i == 0)
            {
                words[i] = words[i].ToLower();
            }
            else
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        Console.WriteLine(string.Join("", words));
    }
}

