using Fundamentals.Working_with_text;
using Fundamentals.Working_with_files;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("What chapter do you want to open?");

string? startFile = args.Length > 0 ? args[0] : null;
// kjør med dotnet run Working_with_files

if(String.IsNullOrWhiteSpace(startFile))
{
    Console.WriteLine("You didn't chose a chapter, program will stop");
    return;
}

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