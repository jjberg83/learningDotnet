using Intermediate.Classes;

Console.WriteLine("Welcome to the Intermediate section!");

string? userInput = args.Length > 0 ? args[0] : null; // bruk for eksempel dotnet run Classes 

if(string.IsNullOrWhiteSpace(userInput))
{
    Console.WriteLine(@"You didn't enter an argument to ""dotnet run <NO ARGUMENT HERE!>"""); 
    return;
}

switch(userInput)
{
    case "Classes":
        Classes_MenuLoop.Run();
        break;
    default:
        Console.WriteLine("No such folder. Program stopping...");
        return;
}