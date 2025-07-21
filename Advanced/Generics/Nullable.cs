namespace Advanced.Generics;

// Value types kan ikke være null i utgangspunktet
// Denne klassen skal gi dem den muligheten
// Her bruker vi en constraint på value types
public class Nullable<T> where T : struct
{
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
