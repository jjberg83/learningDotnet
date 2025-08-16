using Intermediate.Classes;

namespace Advanced.ExtensionMethods;

public class ExtensionMethods
{
    public static void Run()
    {
        // Extension methods lar oss legge til metoder for klasser, uten:
        // - å endre koden i selve klassen
        // - å la klassen arve metoden fra en parent class

        // Extension methods må være static
        // Navnekonvensjon er <KlasseManvilLeggeTilMetoderFor_Extensions>
        // Her gjør vi det for String klassen (ikke mulig å arve fra den)
        // Ikke mulig å arve fra String klassen:
        // public class RichString : String
        // {

        // }

        var blogPost = "This is a very long blog post blah blah blah...";
        Console.WriteLine(blogPost);
        // Man kan se at Shorten har (extension) foran seg hvis man hovrer over metoden
        // Stringen har fått en ny metode her, uten at man endrer noe i String klassen
        Console.WriteLine(blogPost.Shorten(5));


        // Microsoft anbefaler å bruke extension methods så lite som mulig. Hvis mulig, gjør heller dette:
        // - endre klassen direkte (hvis man har tilgang til den- i dette tilfellet endrer vi String, som vi ikke har tilgang til)
        // - lag heller en ny klasse som arver fra klassen man vil legge til metoder for (men ikke alltid det går heller)

        // Så greia er at man bør endre klassen direkte, eller arve fra den og lage en child klasse og legge til nye metoder for
        // child klassen. Men det er ikke alltid man kan det. Da er siste utvei en extension method.

        // Problemet er hvis Microsoft plutselig lager en egen Shorten metode for String klassen. Da vil ikke vår metode
        // gjøre det vi vil, men det Microsoft vil. 

        // I praksis vil man ikke lage extension methods, men bruke dem.

        // Her er et slikt eksempel. Etter punktumet for numbers finnes det flere eksempler på extension methods
        // (men har ikke funnet måte å se det på før man velger. Select er eksempel på en extension method)
        IEnumerable<int> numbers = new List<int>();
        // numbers.Select()

        // Her prøver jeg å lage min egen extension method for String klassen
        blogPost.CamelCase();

        // For moro skyld bruker jeg en klasse jeg tidligere har brukt fra en annen plass i applikasjonen.
        // Selv om jeg kan redigere den direkte, og selv om jeg kan arve fra den, velger jeg, stikk i strid
        // med alle anbefalinger, å lage en extension method for den. Jeg skal gi Coder klassen metoder den
        // opprinnelig ikke har. La meg også teste etterpå, om jeg kan bruke disse extension methods andre plasser
        // i applikasjonen.
        var bigNerdy = new Coder();
        bigNerdy.Strenghts = "Genious mastermind coder";
        bigNerdy.CertificationExpiry = new DateTime(2063, 07, 02);
        //Denne metoden finnes egentlig ikke i Coder klassen, men jeg har lagt den til som en extension
        bigNerdy.Reverse();

    }

}

