using EdabitChallenges;
using System.Runtime.InteropServices;

Console.WriteLine("What challenge do you want to run?");
string? userInput = Console.ReadLine();

switch (userInput)
{
    case "ReverseCase":
        string test1 = Challenges.ReverseCase("Happy Birthday");
        string test2 = Challenges.ReverseCase("MANY THANKS");
        string test3 = Challenges.ReverseCase("sPoNtAnEoUs");
        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
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



