namespace Advanced.Generics;
public class Generics
{
    public static void Run()
    {
        // Først litt repetisjon som er relevant for å forklare hvorfor Generics er bra

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
    }
}