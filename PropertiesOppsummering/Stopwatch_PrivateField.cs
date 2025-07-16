// Her er StartTime et private field. Det er det eneste som er forskjellig fra klassen
// Stopwatch_PublicField
public class Stopwatch_PrivateField
{
    private DateTime _startTime;

    public Stopwatch_PrivateField()
    {
        _startTime = new DateTime();
    }
    public void Start()
    {
        if (_startTime != DateTime.MinValue)
            throw new InvalidOperationException("Man kan ikke starte stoppeklokken to ganger på rad.");
        _startTime = DateTime.Now;
    }

    public void Stop()
    {
        if (_startTime == DateTime.MinValue)
            System.Console.WriteLine("Du må starte stoppeklokken først");
        else
        {
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - _startTime;
            System.Console.WriteLine($"Duration: {duration}");
            _startTime = DateTime.MinValue;
        }
    }
}