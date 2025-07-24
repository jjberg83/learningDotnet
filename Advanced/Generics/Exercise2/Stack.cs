namespace Advanced.Generics.Exercise2;

/* 
Spurte Github Copilot om å gi meg oppgaver for å teste min forståelse av Generics i C#. 
Her er andre oppgave.

Exercise 2: Generic Stack Class
Implement a generic Stack<T> class with the following methods:

void Push(T item)
T Pop()
T Peek()
int Count { get; }
Do not use the built-in Stack<T> from .NET.
*/

public class Stack<T>
{
    private List<T> _list = new List<T>();
    public int Count
    {
        get { return _list.Count; }
    }

    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack er tom!");
        }
        
        var element = _list[Count - 1];
        _list.RemoveAt(Count - 1);
        return element;
    }

    // Får ikke summary tagen til å virke under, og vet ikke hvorfor...
    
    /// <summary>
    /// In the Peek method of your generic Stack<T> class, you should return the item at the top of the 
    /// stack without removing it.If the stack is empty, you should typically throw an 
    /// exception(e.g., InvalidOperationException), just like the built-in .NET Stack<T> does.
    /// </summary>
    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack er tom!");
        }
        return _list[Count - 1];
    }
}