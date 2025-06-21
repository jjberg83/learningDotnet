namespace Intermediate.Interfaces;

public interface ILogger
{
    void LogError(string message);
    void LogInfo(string message);
}

public class DbMigrator : ILogger
{
    public void LogError(string message)
    {
        
    }
    public void LogInfo(string message)
    {
        // Her implementerer vi først bare beskjeder til Console
        Console.WriteLine($"Migration started at {DateTime.Now}");
        Thread.Sleep(1000); // Her ville vi implementert detaljer som faktisk migrerer databasen
        Console.WriteLine($"Migration ended at {DateTime.Now}");

        // Vi ønsker å skrive klasser slik at man kan endre oppførselen til klassen,
        // uten å endre koden. Det oppnår vi med å lage nye klasser, og beholde koden
        // i denne klassen som den er (men man kan ikke bruke koden over da). 
        // Si for eksempel at vi en gang i fremtiden ønsker å logge beskjedene over
        // til en fil, eller en database. Vi må skrive kode som er mer generell
        // (les: bruker interfaces i stedet for - se ILogger)
    }
}
