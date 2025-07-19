namespace Advanced.Generics;

public class ListObjects
{
    private readonly List<object> _list = new List<object>();

    public object this[int index]
    {
        get
        {
            if (_list.Count == 0)
                throw new Exception("Listen inneholder ingen elementer");

            return _list[index];
        }
    }

    public void Add(object element)
    {
        _list.Add(element);
    }
}