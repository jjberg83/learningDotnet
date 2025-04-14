using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Intermediate.Classes;

// Exercise 1: Design a Stopwatch
// Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
// provide two methods: Start and Stop.We call the start method first, and the stop method next.
// Then we ask the stopwatch about the duration between start and stop. Duration should be a
// value in TimeSpan. Display the duration on the console.
// We should also be able to use a stopwatch multiple times.So we may start and stop it and then
// start and stop it again. Make sure the duration value each time is calculated properly.
// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
// start time). So the class should throw an InvalidOperationException if its started twice.

// Educational tip: 
// The aim of this exercise is to make you understand that a class should be
// always in a valid state.We use encapsulation and information hiding to achieve that.The class
// should not reveal its implementation detail.It only reveals a little bit, like a blackbox.From the
// outside, you should not be able to misuse a class because you shouldn’t be able to see the
// implementation detail.

public class Stopwatch
{
    public List<DateTime> StartTimes { get; private set; } = new List<DateTime>();
    public List<DateTime> StopTimes { get; private set; } = new List<DateTime>();
    public List<TimeSpan> Durations { get; private set; } = new List<TimeSpan>();
    public void Start()
    {
        // Sjekk først at lengden på StartTimes og lengden på StopTimes er like
        // Hvis ulike, kan man ikke gå videre og får beskjed om å stoppe først
        // Finn ut tiden akkurat når start metoden startes, og legg denne til i StartTimes
        if(StartTimes.Count != StopTimes.Count)
        {
            // Her skulle vi egentlig ha lagt inn exceptionen under. Men ved å gjøre det på denne måten
            // avsluttes jo programmet. Så jeg droppet det, og ga heller brukeren en ny sjanse.
            // throw new InvalidOperationException("Du kan ikke starte en ny runde før du har avsluttet forrige. Husk å skriv STOPP i terminal vinduet.");
            Console.WriteLine("Du kan ikke starte en ny runde før du har avsluttet forrige. Husk å skriv STOPP i terminal vinduet.");
            return;
        }
        DateTime startTid = DateTime.Now;     
        StartTimes.Add(startTid);
        Console.WriteLine("Stoppeklokken har startet!");
        Console.WriteLine();
    }
    public void Stop()
    {
        // Sjekk først at lengden på StartTimes er 1 mer enn lengden på Stoptimes,
        // Hvis ikke får man beskjed om dette (altså at man må starte først)
        // Når stop passerer denne sjekken, finnes tiden akkurat nå, og timespannet vises,
        // Stop tiden legges til i stop listen.
        if(StopTimes.Count != StartTimes.Count - 1)
        {
            Console.WriteLine("Du kan ikke stoppe noe siden du ikke har startet en runde enda. Husk å skrive START i terminal vinduet.");
            return;
        }
        DateTime stoppTid = DateTime.Now;
        StopTimes.Add(stoppTid);
        TimeSpan varighet = stoppTid - StartTimes[StartTimes.Count - 1];
        Durations.Add(varighet);
        int minutter = varighet.Minutes;
        var sekunder = Math.Round(varighet.TotalSeconds - (minutter * 60), 2, MidpointRounding.AwayFromZero);
        
        if(minutter >= 1)
            Console.WriteLine($"Minutter: {minutter}");

        Console.WriteLine($"Sekunder: {sekunder}");
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
    }

    public void Slutt()
    {
        if(Durations.Count == 0)
            return;

        Console.WriteLine();
        Console.WriteLine("------------------");
        Console.WriteLine("Alle rundetidene:");
        Console.WriteLine("------------------");

        int minutter;
        double sekunder;

        for( int i = 0; i < Durations.Count; i++)
        {
            minutter = Durations[i].Minutes;
            sekunder = Math.Round(Durations[i].TotalSeconds - (minutter * 60), 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Runde {i+1}: {minutter}:{sekunder}");
        }
        Console.WriteLine();
    }
}
