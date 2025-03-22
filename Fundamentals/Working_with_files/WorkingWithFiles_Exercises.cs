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
        
        Dictionary<int, List<string>> wordLengths = new Dictionary<int, List<string>>();
        foreach(string word in textFromFileInArray)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"{word} -> {word.Length} characters");
            if(word.Length > charactersInLongestWord)
            {
                charactersInLongestWord = word.Length;
            }
            if(!wordLengths.ContainsKey(word.Length))
            {
                wordLengths[word.Length] = new List<string>();
            }
            wordLengths[word.Length].Add(word);
        }

        Console.WriteLine($"The longest word(s) contain(s) {charactersInLongestWord} characters:");
        foreach(string word in wordLengths[charactersInLongestWord])
        {
            Console.WriteLine(word);
        }
    }
}

