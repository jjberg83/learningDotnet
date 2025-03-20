using System.IO;

namespace Fundamentals.Working_with_files;

public class PathI
{
    public static void Run()
    {
        string filePath = "/Users/jjberg/Github/learningDotnet/Fundamentals/Working_with_files/Path.cs";

        // En kjip måte å få ut hvilken extension denne filen har
        int dotIndex = filePath.IndexOf(".");
        string extension = filePath.Substring(dotIndex);
        Console.WriteLine($"Extension for denne filen er: {extension}");

        // En annen kjip måte å gjøre det på
        string extension2 = filePath.Substring(filePath.Length-3);
        // Hvis man ikke er sikker på hvor lang stringen er bør man bruke Math.Max slik:
        string extension3 = filePath.Substring(Math.Max(0, filePath.Length-3));
        Console.WriteLine($"Extension for denne filen er: {extension2}");
        Console.WriteLine($"Extension for denne filen er: {extension3}");

        Console.WriteLine("##########################");
        Console.WriteLine("Tøffere måter å få ut slik info på");
        Console.WriteLine("##########################");

        string extension4 = Path.GetExtension(filePath);


    }
}