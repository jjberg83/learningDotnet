using Fundamentals.Working_with_text;
using Fundamentals.Working_with_files;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Fundamentals!");

string? startFile = Environment.GetEnvironmentVariable("startfile");

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