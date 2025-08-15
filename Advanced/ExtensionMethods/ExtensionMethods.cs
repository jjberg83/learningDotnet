using System.Security.Cryptography.X509Certificates;

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
        // public class Shorten : String
        // {

        // }

        var blogPost = "This is a very long blog post blah blah blah...";
        blogPost.Shorten(5);


    }

}

