using EdabitChallenges;

Console.WriteLine("What challenge do you want to run?");
string? userInput = Console.ReadLine();

switch (userInput)
{
    case "Stuttering":
        Challenges.Stuttering();
        break;
    case "Syllables":
        Challenges.Syllables();
        break;
    default:
        Console.WriteLine("No such directory");
        break;
}



