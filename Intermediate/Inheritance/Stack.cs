namespace Intermediate.Inheritance;

internal class Stack
{
    // Lister bør alltid ha readonly og initialiseres her eller i konstruktør
    // Da kan liste-instansen aldri lages på ny, og alt dens innhold slettes ved et uhell
    // men listens elementer kan likevel legges til og trekkes fra
    private readonly List<object> _elements = new();
    public void Push(object obj)
    {
        if(obj == null)
            throw new InvalidOperationException("You cannot add a null object to the stack");
        _elements.Add(obj);
    }

    public object Pop()
    {
        if(_elements.Count == 0)
            throw new InvalidOperationException("You cannot Pop an element from an empty list");
        object objectToBeRemoved = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return objectToBeRemoved;
    }

    public void Clear()
    {
        _elements.Clear();
    }
}
