// Her er StartTime et public field. Ellers er alt likt som i klassen
// StopWatch_PrivateField
public class Stopwatch_PublicField
{
    public DateTime StartTime;

    public Stopwatch_PublicField()
    {
        StartTime = new DateTime();
    }
    public void Start()
    {
        if (StartTime != DateTime.MinValue)
            throw new InvalidOperationException("Man kan ikke starte stoppeklokken to ganger på rad.");
        StartTime = DateTime.Now;
    }

    public void Stop()
    {
        if (StartTime == DateTime.MinValue)
            System.Console.WriteLine("Du må starte stoppeklokken først");
        else
        {
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - StartTime;
            System.Console.WriteLine($"Duration: {duration}");
            StartTime = DateTime.MinValue;
        }
    }
}