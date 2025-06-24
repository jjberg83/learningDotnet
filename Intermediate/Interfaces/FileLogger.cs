namespace Intermediate.Interfaces;

public class FileLogger : ILogger
{
    private readonly string _path;
    public FileLogger(string path)
    {
        _path = path;
    }

    // Vi lager en intern metode siden både LogError og LogInfo bruker samme logikk (så slipper vi å repetere kode)
    // litt forskjeller i hva som skrives til filen, men det håndterer vi med
    // parameteren message
    public void LogError()
    {
        Log($"Error occured at {DateTime.Now}");
    }
    public void LogInfo()
    {
        Log($"Database started migration at {DateTime.Now}");
        Thread.Sleep(1000);
        Log($"Database finished migration at {DateTime.Now}");
    }

    // StreamWriter er en såkalt FileResoucre, som ikke håndteres av CLR
    // Derfor må vi bruke using for å ta oss av disposal (forsto det ikke helt)
    // Exception mechanism implementeres nå av compileren ved å bruke using
    // Hvis noe går galt, sørger nå altså compileren for å dispose (vi slipper å skrive streamWriter.Dispose())
    private void Log(string message)
    {
        using (var streamWriter = new StreamWriter(_path, true))
        {
            streamWriter.WriteLine(message);
        }
    }

}