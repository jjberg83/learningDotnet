using Fundamentals.Working_with_text;
using Fundamentals.Working_with_files;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("What chapter do you want to open?");

// string? startFile = Environment.GetEnvironmentVariable("startfile");
string? startFile = Console.ReadLine();

switch (startFile)
{
    case "Working_with_files":
        WorkingWithFiles_MenuLoop.Run();
        break;
    case "Working_with_text":
        WorkingWithText_MenuLoop.Run();
        break;
    default:
        Console.WriteLine("No such directory");
        break;
}