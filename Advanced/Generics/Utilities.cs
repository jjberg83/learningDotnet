namespace Advanced.Generics;

// Legg merke til at denne klassen ikke er generisk (tror det vil si at den ikke
// inneholder noen <T> i seg), selv om den inneholder en generisk metode inni seg
// Likevel kan vi gjør klassen generisk, og da slipper man å ha akkurat denne delen
// av T-delen i metoden:
// public class Utilities<T> where T : IComparable
// Jeg ser ikke helt den store nytten, siden vi fortsatt må ha litt av T-ene
// nede i metoden likevel (kan bare sløyfe where T : IComparable fra metoden, ikke det andre)
public class Utilities
{
    // I denne metoden vet man datatypen man skal finne den største av, 
    // så C# har ingen problemer med så sammenligne de to int'ene.
    public int Max(int firstNumber, int secondNumber)
    {
        return firstNumber > secondNumber ? firstNumber : secondNumber;
    }

    // Men skriver man en generell metode for å finne det største av to datatyper,
    // men man på forhånd ikke vet hvilken datatype som legges inn, kan man ikke
    // bare skrive følgende kode
    // public T Max<T>(T firstElement, T secondElement)
    // {
    //     return firstElement > secondElement ? firstElement : secondElement;
    // }

    // I stedet må man bruke constraint, og det gjør man med å først si i signaturen
    // at T må implementere interfacet IComparable (den inneholder en nyttig metode for sammenligning av datatyper)
    public T Max<T>(T firstElement, T secondElement) where T : IComparable
    {
        return firstElement.CompareTo(secondElement) > 0 ? firstElement : secondElement;
        // positive tall betyr at firstElement er større
        // 0 betyr at de er like
        // negative tall betyr at secondElement er større
    }

    // Her har man en constraint på at objektet må ha en default constructor
    public T DoSomething<T>(T value) where T : new()
    {
        return new T();
    }


}
