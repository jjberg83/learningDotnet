using Intermediate.Classes;

// Man bruker det han kaller globale exception handlers for hele Program.cs
// og så legger man inn exceptions der det kan krasje (i stedet for mange try/catch blokker overalt)
try 
{
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
}
catch
{
    Console.WriteLine("En uventet feil skjedde");
}
