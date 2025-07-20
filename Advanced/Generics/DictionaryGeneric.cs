namespace Advanced.Generics;

public class DictionaryGeneric<TKey, TValue>
{
    private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();
    public TValue this[TKey key]
    {
        get { return _dictionary[key]; }
    }

    public void Add(TKey key, TValue value)
    {
        _dictionary[key] = value;
    }
}
