using System.Collections;

namespace Intermediate.Inheritance;

public class BoxingAndUnboxing
{
    public static void Run()
    {
        // Boxing er når en value type konverteres til en reference type
        // Selv om 7 er int, er alle ints også objects, så dette går
        object objekt = 7;

        // Unboxing er når vi går andre veien, altså at reference types
        // konverteres til value types
        int tall = (int)objekt;

        // Det ligner veldig på upcasting og downcasting siden, men der så
        // vi på base classes og derived classes. Her skifter vi mellom
        // reference og value types. Når man har boxing lagrer man en value
        // type i heapen (ved å bokse det inn i en referansetype). Når 
        // man unboxer, tar man ut value typen fra reference typen. 

        // Det har en kostnad fordi man må allokere plass av og på i heapen, 
        // i tillegg til man må sjekke typer.

        ArrayList list = new ArrayList();
        // Gjett om dette er boxing eller unboxing
        // Husk at Add metoden tar object som parameter
        list.Add(1); // -> 1
        list.Add("Jørund"); // -> 2
        list.Add(DateTime.Today); // -> 3




        // 1: Boxing. En value type bokses inn i object, som er reference type. Int verdien lagres nå i heapen.
        // 2: Lurespørsmål. En referansetype blir om til en referansetype. Verken boxing eller unboxing.
        // 3: Structs er value types. Derfor blir dette boxing.

        // La meg kjøre value type testen for å se bevis på at en struct er en value type
        // struct quiz = new quiz();
    }
}
