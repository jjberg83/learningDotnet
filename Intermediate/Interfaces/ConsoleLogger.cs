namespace Intermediate.Interfaces;

// I denne implementasjonen logger vi til Console
public class ConsoleLogger : ILogger
{
    public void LogInfo()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine($"Database started migration at {DateTime.Now}");
        Thread.Sleep(1000);
        Console.WriteLine($"Database finished migration at {DateTime.Now}");
    }

    public void LogError()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"Error occured at {DateTime.Now}");
    }
}