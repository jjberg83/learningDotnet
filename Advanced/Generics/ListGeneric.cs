namespace Advanced.Generics;

public class ListGeneric<T>
{
    private readonly List<T> _list = new List<T>();

    public T this[int index]
    {
        get
        {
            if (_list.Count == 0)
                throw new Exception("Listen inneholder ingen elementer");

            return _list[index];
        }
    }

    public void Add(T value)
    {
        _list.Add(value);
    }
}
