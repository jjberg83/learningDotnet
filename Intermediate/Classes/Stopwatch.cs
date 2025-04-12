namespace Intermediate.Classes;

// Exercise 1: Design a Stopwatch
// Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
// provide two methods: Start and Stop.We call the start method first, and the stop method next.
// Then we ask the stopwatch about the duration between start and stop. Duration should be a
// value in TimeSpan.Display the duration on the console.
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
    public void Start()
    {
        // Sjekk først at lengden på StartTimes og lengden på StopTimes er like
        // Hvis ulike, kan man ikke gå videre og får beskjed om å stoppe først
        // Finn ut tiden akkurat når start metoden startes, og legg denne til i StartTimes        
    }
    public void Stop()
    {
        // Sjekk først at lengden på StartTimes er 1 mer enn lengden på Stoptimes,
        // Hvis ikke får man beskjed om dette (altså at man må starte først)
        // Når stop passerer denne sjekken, finnes tiden akkurat nå, og timespannet vises,
        // Stop tiden legges til i stop listen.

        // Kan jo tømme listene etter hver gang. Ikke nødvendig å fylle opp. Bare nødvendig for en gangs bruk og så tømme.
        // Kanskje readonly var en dum ide?
    }
}
