namespace Fundamentals.Working_with_text;

//Note: For all these exercises, ignore input validation unless otherwise specified. 
// Assume the user provides input in the format that the program expects.

// This is a copy of my solutions in the file called WorkingWithText_Exercises.cs,
// but here I am translating my code to follow the principles of Procedural programming.
// Basically, I am separating code that has to do with my Console, from business logic.
// Business logic can be used by any application (Console App, Razor Pages, mobile app etc), 
// whilst the Console part has to be rewritten to suit the kind of app I am developing.
// All the code within the methods called Exercise<Number>() contains Console code,
// whilst all the business logic code is at the bottom of this file.

public class WorkingWithText_Exercises_ProceduralProgrammingStyle
{
    //1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
    // Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or 
    // "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
    public static void Exercise1()
    {
        Console.WriteLine("This is Exercise 1");
    }
    // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
    // If the user simply presses Enter, without supplying an input, exit immediately; 
    // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
    // 
    public static void Exercise2()
    {
        Console.WriteLine("Enter a few numbers separated by a hyphen:");
        string? userInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("You did not enter anything, exercise will stop");
            return;
        }
        Console.WriteLine(CheckForDuplicates(userInput)); // By this point we know that the input is not null, and can pass it to the function
    }

    
    //3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
    // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
    // display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
    public static void Exercise3()
    {
        Console.WriteLine("Please enter a time value in the 24-hour time format (between 00:00 and 23:59):");
        string? userInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("You didn't enter anything, exercise will stop...");
            Console.WriteLine("Invalid format");
            return;
        }
        try
        {
            DateTime clockTime = DateTime.ParseExact(userInput, "HH:mm", null);
            Console.WriteLine("Valid format");

        }
        catch(Exception ex)
        {
            Console.WriteLine("Invalid format");
        }
    }
    // 4- Write a program and ask the user to enter a few words separated by a space. 
    // Use the words to create a variable name with PascalCase. For example, 
    // if the user types: "number of students", display "NumberOfStudents". 
    // Make sure that the program is not dependent on the input. So, if the user 
    // types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
    public static void Exercise4()
    {
        Console.WriteLine("Enter a few words separated by a space:");
        string? userInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("You didn't enter anything. Exercise will stop");
            return;
        }
        
        string variableNameInPascalCase = "";
        foreach(string word in userInput.Split()) // Cool trick I learned from the instructor, define the variable inside foreach
        {
            variableNameInPascalCase += word.Substring(0,1).ToUpper() + word.Substring(1).ToLower();
        }
        Console.WriteLine(variableNameInPascalCase);
    }

    //5- Write a program and ask the user to enter an English word. Count the number of 
    // vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program 
    // should display 6 on the console.
    public static void Exercise5()
    {
        Console.WriteLine("Enter an English word:");
        string userInput = Console.ReadLine().Trim().ToLower();
        int count = 0;
        List<char> vowels = new List<char>() {'a', 'e','i','o','u'};
        foreach(char letter in userInput)
        {
            if(vowels.Contains(letter))
            {
                count++;
            }
        }
        Console.WriteLine($"The word you entered contains {count} vowels.");
    }

    ////////////////////////////////////////////
    /// BUSINESS LOGIC (code that can be applied by any application)
    ////////////////////////////////////////////
    ///

    public static string CheckForDuplicates(string userInput)
    {
        string[] numbers = userInput.Split('-');
        if( (string.IsNullOrWhiteSpace(numbers[numbers.Length-1]) && numbers.Length == 2) || (numbers.Length < 2) )
        {
            return "You did not enter MANY numbers, exercise will stop";
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = 0; j < numbers.Length; j++)
            {
                if(i == j)
                {   
                    continue;
                }
                if(numbers[i] == numbers[j])
                {
                    return "Duplicates exist...";
                }
            }
        }
        return "No duplicates";
    }
}