namespace Fundamentals.Working_with_files;

public class WorkingWithFiles_Exercises
{
    // 1- Write a program that reads a text file and displays the number of words.
    public static void Exercise1()
    {   
        string filePath = "/Users/jjberg/Github/learningDotnet/Fundamentals/Working_with_files/SamlingSitater.txt";
        string textFromFile = File.ReadAllText(filePath);
        string[] textFromFileInArray = textFromFile.Split(" ");
        Console.WriteLine(textFromFile);
        Console.WriteLine($"{Path.GetFileName(filePath)} has {textFromFileInArray.Length} words in it");
    }
    // 2- Write a program that reads a text file and displays the longest word in the file.
    public static void Exercise2()
    {
        string filePath = "/Users/jjberg/Github/learningDotnet/Fundamentals/Working_with_files/SamlingSitater.txt";
        string textFromFile = File.ReadAllText(filePath);
        string[] textFromFileInArray = textFromFile.Split(" ");
        int charactersInLongestWord = 0;
        Dictionary<int, string[]> wordLengths = new Dictionary<int, string[]>();

        foreach(string word in textFromFileInArray)
        {
            Console.WriteLine($"{word} -> {word.Length} characters");
            //wordLengths.Add()
            if (word.Length > charactersInLongestWord)
            {
                charactersInLongestWord = word.Length;
            }
        }

        Console.WriteLine($"The longest word in the file was {charactersInLongestWord} characters long");
    }
}

