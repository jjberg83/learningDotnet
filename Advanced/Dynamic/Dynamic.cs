namespace Advanced.Dynamic;

public class Dynamic
{
    public static void Run()
    {
        /*
        Det finnes to typer programmeringsspråk:
        - statically typed (C#, Java)
        - dynamically typed (Ruby, JavaScript, Python)

        I statiske språk blir resolution of types, members, properties, methods avgjort ved kompilering.
        I dynamiske, blir de avgjort ved runtime. Sagt på en annen måte, i statiske språk krasjer programmet
        ved feil i koden ved kompilering. I dynamiske krasjer de når man kjører koden.
        */

        object obj = "Jørund";

        // Her skaffer han hashcode (vet ikke detaljene om denne metoden) på "vanlig" måte
        // var hashcode = obj.GetHashCode();
        // Console.WriteLine(hashcode);

        // Og her gjør han det med Reflections (han kaller det messy og ugly)
        // GetType -> returnerer System.String
        var hashcode = obj.GetType().GetMethod("GetHashCode");


    }
}