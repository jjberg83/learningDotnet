namespace Intermediate.Interfaces;

// I denne implementasjonen logger vi til Console
public class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"Database started migration at {DateTime.Now}");
        Console.WriteLine($"Message: {message}");
        Thread.Sleep(1000);
        Console.WriteLine($"Database finished migration at {DateTime.Now}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"Error occured at {DateTime.Now}");
        Console.WriteLine($"Message: {message}");
    }
}