using EdabitChallenges;
using System.Runtime.InteropServices;

Console.WriteLine("What challenge do you want to run?");
string? userInput = Console.ReadLine();

switch (userInput)
{
    case "ReverseAndNot":
        string test7 = Challenges.ReverseAndNot(123);
        string test8 = Challenges.ReverseAndNot(152);
        string test9 = Challenges.ReverseAndNot(123456789);
        Console.WriteLine(test7);
        Console.WriteLine(test8);
        Console.WriteLine(test9);
        break;
    case "FormatDate":
        string test1 = Challenges.FormatDate("11/12/2019");
        string test2 = Challenges.FormatDate("12/31/2019");
        string test3 = Challenges.FormatDate("01/15/2019");
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
        break;
    case "ReverseCase":
        string test4 = Challenges.ReverseCase("Happy Birthday");
        string test5 = Challenges.ReverseCase("MANY THANKS");
        string test6 = Challenges.ReverseCase("sPoNtAnEoUs");
        Console.WriteLine(test4);
        Console.WriteLine(test5);
        Console.WriteLine(test6);
        break;
    case "Stuttering":
        Challenges.Stuttering();
        break;
    case "Syllables":
        Challenges.Syllables();
        break;
    case "ArrayOfMultiples":
        int[] multiplesOfX = Challenges.ArrayOfMultiples(7,5);
        break;
    default:
        Console.WriteLine("No such directory");
        break;
}



