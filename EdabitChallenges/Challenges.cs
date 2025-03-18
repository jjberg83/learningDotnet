namespace EdabitChallenges;

public static class Challenges
{
    // LINK
    // https://edabit.com/challenge/Ty9u8onXNjDPdQGMo
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
        string userInput = getUserInput();
        if(userInput.Length > 0)
        {
            string firstTwoLetters = userInput.Substring(0,2);
            Console.WriteLine($"{firstTwoLetters}... {firstTwoLetters}... {userInput}");
        }
    }

    // LINK
    // https://edabit.com/challenge/SB26jFMaQE6kf7gE5

    // Create a function that counts the number of syllables a word has. Each syllable is separated with a dash -.

    // EXAMPLES
    // NumberSyllables("buf-fet") ➞ 2
    // NumberSyllables("beau-ti-ful") ➞ 3
    // NumberSyllables("mon-u-men-tal") ➞ 4
    // NumberSyllables("on-o-mat-o-poe-ia") ➞ 6

    public static void Syllables
    {
        string userInput = getUserInput();
        if(userInput.Length > 0)
        {
            
        }
    }

    public static string getUserInput()
    {
        Console.WriteLine("Please enter a word:");
        string? userInput = Console.ReadLine();
        if(String.IsNullOrWhiteSpace(userInput))
        {
            return "";
        }
        else 
        {
            return userInput;
        }
    }
}