namespace Intermediate.Inheritance;

internal class Stack
{
    // Lister bør alltid ha readonly og initialiseres her eller i konstruktør
    // Da kan liste-instansen aldri lages på ny, og alt dens innhold slettes ved et uhell
    // men listens elementer kan likevel legges til og trekkes fra
    // MEN, siden Clear metoden skal slette alt innholdet, bruker jeg ikke readonly under
    // Da måtte jeg loopet gjennom listen og slettet hvert element, som er costly
    // Fieldet er privat uansett, så jeg trenger kun følge med på potensielle farlige
    // nye opprettelser av instanser her inne (som vil slette hele listens innhold)
    private List<object> _elements;
    public void Push(object obj)
    {
        if(obj == null)
            throw new InvalidOperationException();
        if(_elements.Count == 0)
            _elements = new();
        _elements.Add(obj);
    }

    public object Pop()
    {
        if(_elements.Count == 0)
            throw new InvalidOperationException();
        else
        {
            object objectToBeRemoved = _elements[-1];
            _elements.RemoveAt(-1);
            return objectToBeRemoved;
        }
    }

    public void Clear()
    {
        _elements = new();
    }
}
