using System.Globalization;

namespace EdabitChallenges;

public static class Challenges
{
    // LINK
    // https://edabit.com/challenge/mcdSLSmXjYMzEmug2
    // Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.

    // FormatDate("11/12/2019") ➞ "20191211"
    // FormatDate("12/31/2019") ➞ "20193112"
    // FormatDate("01/15/2019") ➞ "20191501"

    public static string FormatDate(string date)
    {
        string[] dateSplitted = date.Split("/");
        return $"{dateSplitted[2]}{dateSplitted[1]}{dateSplitted[0]}";
    }


    // LINK
    // https://edabit.com/challenge/99oN5igrbXddAjHEL
    // Given a string, create a function to reverse the case. 
    // All lower-cased letters should be upper-cased, and vice versa.

    // Examples
    // ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"
    // ReverseCase("MANY THANKS") ➞ "many thanks"
    // ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"

    public static string ReverseCase(string str)
    {   
        string reverseCase = "";
        foreach(char letter in str)
        {
            if(Char.IsUpper(letter))
            {
                reverseCase += Char.ToLower(letter);
            }
            else
            {
                reverseCase += Char.ToUpper(letter);
            }
        }
        return reverseCase;
    }


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

    public static void Syllables()
    {
        string userInput = getUserInput();
        if(userInput.Length > 0)
        {
            Console.WriteLine($"There are {userInput.Split("-").Length} syllables in the word you entered");
        }
    }

    // LINK
    // https://edabit.com/challenge/2QvnWexKoLfcJkSsc

    // Create a function that takes two numbers as arguments (num, length) and returns 
    // an array of multiples of num until the array length reaches length.

    // EXAMPLES

    // ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
    // ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
    // ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]

    // Notice that num is also included in the returned array.


    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] multiplesOfX = new int[length];
        for(int i = 1; i < length; i++)
        {
            multiplesOfX[i-1] = num * i;
        }
        return multiplesOfX;
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