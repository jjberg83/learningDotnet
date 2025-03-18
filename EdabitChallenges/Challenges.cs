namespace EdabitChallenges;

public static class Challenges
{
    // Write a function that stutters a word as if someone is struggling to read it. 
    // The first two letters are repeated twice with an ellipsis ... and space after each, 
    // and then the word is pronounced with a question mark ?.

    // EXAMPLES
    // Stutter("incredible") ➞ "in... in... incredible?"
    // Stutter("enthusiastic") ➞ "en... en... enthusiastic?"
    // Stutter("outstanding") ➞ "ou... ou... outstanding?"
    // NOTES
    // Assume all input is in lower case and at least two characters long.

    public static void Stuttering()
    {
        Console.WriteLine("Please enter a word:");
        string? userInput = Console.ReadLine();
        if(String.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("You didn't enter anything. Challenge will stop");
            return;
        }
        string firstTwoLetters = userInput.Substring(0,2);
        Console.WriteLine($"{firstTwoLetters}... {firstTwoLetters}... {userInput}");
    }
}