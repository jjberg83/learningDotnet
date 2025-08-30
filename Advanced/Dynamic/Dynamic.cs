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

        // Her skaffer han hashcode på "vanlig" måte
        // Det vil si, siden vi er i C#, VET vi at object har en metode som heter GetHashCode
        // Derfor kan vi lett gjøre dette
        var hashcode = obj.GetHashCode();
        Console.WriteLine(hashcode);

        // Og her gjør han det med Reflections (han kaller det messy og ugly)
        // Og jeg får det ikke til å virke en gang!
        // Poenget, som jeg har sett i Reflections når jeg bruker det i stedet
        // for menyloopene mine, er at vi antar at det skal finnes en metdoe kalt
        // GetHashCode.
        // var methodInfo = obj.GetType().GetMethod("GetHashCode", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        // var hashcode = methodInfo.Invoke(null, null);
        // Console.WriteLine(hashcode);

        // Man kan gjøre det samme med Dynamic, men det ser helt likt ut som vanlig C# kode
        // Se for deg at man får inn et Excel object, og man vet at det objektet skal ha 
        // en metode kalt Optimize. Det er ikke en metode som finnes i Dotnet. Men ved
        // å bruke Dynamics i stedet for Reflections, kan man gjøre det som under.

        // Dette går ikke, fordi Dotnet ikke aner noe om en metode kalt Optimize.
        // object excelObject = "Excel"; // Her lager vi string bare fordi vi ikke har et ekte Excel objekt, men hadde funket uansett.
        // excelObject.Optimmize(); // Her ser man at metoden ikke finnes i Dotnet verden

        // Alle ting i C# er objects, og det er derfor vi gir den typen til hva enn vi får inn fra Excel
        // Men som du ser finnes ikke den metoden for object. Ved å gjøre typen om til Dynamic, løser alt seg
        dynamic dynamicExcelObject = "Excel";
        dynamicExcelObject.Optimize(); // Ingen feilmelding!







    }
}