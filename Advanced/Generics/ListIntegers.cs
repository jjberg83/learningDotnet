namespace Advanced.Generics;

// I utgangspunktet var klassen lik det du ser nederst kommentert ut.
// Jeg bestemte meg for å prøve å implementere denne klassen selv før jeg
// så noe videre. Jeg har sett indexers brukt med dictionary som backing field før.
// Men det kan visst brukes med envher collection type. Så jeg prøver det med 
// en liste, som vil være naturlig i dette tilfellet.
public class ListIntegers
{
    private readonly List<int> _list = new List<int>();
    // Dette er en indexer
    public int this[int index]
    {
        get
        {
            if (_list.Count() == 0)
                throw new Exception("Listen inneholder ingen elementer");
            return _list[index];
        }
    }

    public void Add(int number)
    {
        _list.Add(number);
    }
}

/*
public class ListIntegers
{
    // Dette er en indexer
    public int this[int index]
    {
        get { throw new NotImplementedException(); }
    }

    public void Add(int number)
    {
        throw new NotImplementedException();
    }
}
*/
