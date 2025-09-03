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
        // Poenget, som jeg har sett i menyloopene mine der jeg bruker Reflections,
        // er at vi antar at det skal finnes en metode kalt GetHashCode.
        var methodInfo = obj.GetType().GetMethod("GetHashCode", Type.EmptyTypes);
        var hashcodeWithReflections = methodInfo.Invoke(obj, null);
        Console.WriteLine(hashcodeWithReflections);

        // Man kan gjøre det samme med Dynamic, men det ser helt likt ut som vanlig C# kode
        // Se for deg at man får inn et Excel object, og man vet at det objektet skal ha 
        // en metode kalt Optimize. Det er ikke en metode som finnes i Dotnet. Men ved
        // å bruke Dynamics i stedet for Reflections, kan man gjøre det som under. Vi simulerer altså et Excel objekt med en string.

        // Optimize funksjonen under feiler allerede ved kompilering (man får røde streker, og kan ikke bygge)
        // object excelObject = "Excel"; 
        // excelObject.Optimmize(); // 

        // Ved kompilering feiler ikke dette (dotnet build sier GO). Men ved runtime gjør det det, fordi metoden er fiktiv og kom aldri inn
        // Metoden kan altså ikke kalles på ved runtime, men det er OK ved kompilering.
        dynamic dynamicExcelObject = "Excel";
        // dynamicExcelObject.Optimize();

        // Han bare nevner kort at Dynamics virker under the hood ved at det sitter en DLR,
        // altså en Dynamic Language Runtime, oppå CLR, Common Language Runtime, som oversetter
        // Intermediate Language (IL) om til machine kode for den spesifikke maskinen som kjører koden

        // Man får også muligheten til å bruke variabler som om de skulle vært Python variabler
        // (altså at en variabel først kan være en string, og så plutselig være en int)
        dynamic navn = "Jørund";
        navn = 1;
        Console.WriteLine(navn);

        // Her ser man et nytt eksempel på noe som ikke feiler ved kompilering (dotnet build),
        // men feiler ved runtime (dotnet run)
        dynamic myString = "Koding er kjekt";
        // myString++;

        // Ved kompilering er altså typen dynamic, men ved runtime får de en faktisk type (string, int osv)
        // Her er et annet eksempel. Alle disse typene er Dynamic ved kompilering, men alle blir ints ved runtime
        dynamic a = 10;
        dynamic b = 5;
        var c = a + b;
        // Hovrer man over variablene er de dynamic. Men når vi skriver datatypene ut er de ints
        Console.WriteLine($"a -> {a.GetType()}");
        Console.WriteLine($"b -> {b.GetType()}");
        Console.WriteLine($"c -> {c.GetType()}");

        // Det går også fint å gå andre veien, fra en viss type til dynamic. Her er e dynamic ved kompilering, og int ved runtime.
        // I f, er det ingen problem å legge inn Int32 inn i en Int64.
        int d = 3;
        dynamic e = d;
        long f = e;
        Console.WriteLine($"e -> {e.GetType()}");
        Console.WriteLine($"f -> {f.GetType()}");

        // Jeg prøvde å bytte ut menyloopene mine som jeg har i Program.cs filene mine. De bruker Reflections.
        // Jeg fikk ikke til å gjøre det bedre med dynamic. Problemet tror jeg har noe å gjøre med at
        // Reflections virker bra på tekst input, mens dynamic virker bra på variabler. 





    }
}