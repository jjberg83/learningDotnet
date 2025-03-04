namespace Fundamentals.Working_with_text;

//Note: For all these exercises, ignore input validation unless otherwise specified. 
// Assume the user provides input in the format that the program expects.



//3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

//4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

//5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

public class WorkingWithText_Exercises
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
        string[] numbers = userInput.Split('-');
        if( (string.IsNullOrWhiteSpace(numbers[numbers.Length-1]) && numbers.Length == 2) || (numbers.Length < 2) )
        {
            Console.WriteLine("You did not enter MANY numbers, exercise will stop");
            return;
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
                    Console.WriteLine("Duplicates exist...");
                    return;
                }
            }
        }
        Console.WriteLine("No duplicates");
    }
    public static void Exercise3()
    {
        Console.WriteLine("This is Exercise 3");
    }
    public static void Exercise4()
    {
        Console.WriteLine("This is Exercise 4");
    }
    public static void Exercise5()
    {
        Console.WriteLine("This is Exercise 5");
    }
}