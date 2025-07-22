namespace Advanced.Generics;

// Value types kan ikke være null i utgangspunktet
// Denne klassen skal gi dem den muligheten
// Her bruker vi en constraint på value types
// Jeg lagde metoden MakeNullable, resten er instruktørens kode
public class Nullable<T> where T : struct
{
    private object _value;

    public Nullable()
    {

    }

    public Nullable(T value)
    {
        // Her boxer vi (gjør value type om til reference type). Hvis value type ikke har 
        // blitt instansiert, eller fått en verdi, blir verdien om til null siden den 
        // boxes her (blir gjort om til reference type)
        _value = value; 
    }

    public bool HasValue
    {
        get { return _value != null; } 
    }

    public T GetValueOrDefault()
    {
        // Her unboxer vi igjen (gjør reference type om til value type)
        // Hvis det finnes en verdi, overføres denne verdien til en value type
        // Hvis det ikke finnes en verdi, altså at reference type har verdien null,
        // blir dette om til defaulten for den value typen T omgjøres til
        if (HasValue)
            return (T)_value; 

        return default(T);
    }

    public object MakeNullable(T value)
    {
        object boxedVariable = value;
        return boxedVariable;
        // etter at verdien returneres som et object, kan man derfra gjøre den om til null
    }
}

// Instruktør gjorde det slik:

/*
public class Nullable<T> where T : struct
{
    private object _value;

    public Nullable(T value)
    {
        _value = value;
    }
}
*/
