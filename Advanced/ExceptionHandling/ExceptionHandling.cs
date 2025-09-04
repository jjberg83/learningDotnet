namespace Advanced.ExceptionHandling;

public class ExceptionHandling
{
    // Første TRY-CATCH eksempel:
    // Man bør alltid ha én global exception handling mechanism
    // Run nedenfor simulerer Main metoden i en Console Application, og er startpunktet
    // I andre løsninger, som for eksempel RazorPages applikasjon, vil man putte denne 
    // try-catch blokken i det tilsvarende startpunktet

    // Vanig å ha flere catch blokker etter hverandre. Alltid ha de mest spesifikke øverst,
    // og mer generelle etterhvert som man beveger seg nedover. Hver exception er egentlig en
    // klasse, og helt nederst kommer moderklassen for alle exceptions, nemlig Exception

    // Kjører du koden i debug mode, og setter en breakpoint på linjen hvor man kaller Divide metoden
    // med en 0 som argument 2, får man se hvilken helt spesifikke exception som skjer. Søk den så
    // opp på nettet, og derfra kan man se exception hierarkiet fra generell til det helt innerste
    // nivået (hvis man ønsker å gjøre forskjellige ting alt etter hvilket nivå exceptionen skjer på under).
    // I dette tilfellet ser jeg i debug mode at jeg får DivideByZeroException. Søker jeg denne
    // exceptionen, eller rettere sagt klassen, opp på nettet finner jeg at hierarkiet ser slik ut
    // (fra generell til mer og mer spesifikk):
    // Inheritance: Object(alt er jo objekter) > Exception > SystemException > ArithmeticException > DivideByZeroException
    // Dette kan jeg bruke for å lage catch blokker under.
    // De fungerer som return, når du først går inn i en, skjer ikke alle under.

    // Andre TRY-CATCH eksempel:
    // Han snakker om "unmanaged resources", altså ting som det ikke finnes automatisk garbage collection på.
    // Eksempler han nevner er når man åpner filer (som med StreamReader), har connections til nettverk eller databaser.
    // Det er viktig å lukke disse og rydde opp hvis noe går gale (altså i finally blokken helt sist). Det gjør man ved å bruke 
    // et interface kalt IDisposable, og metoden Dispose().

    public static void Run()
    {
        // Første TRY-CATCH eksempel.
        // try
        // {
        //     var calculator = new Calculator();
        //     calculator.Divide(3, 0);
        // }
        // catch (DivideByZeroException e)
        // {
        //     Console.WriteLine("Du fikk en DivideByZeroException. De under skjer ikke.");
        // }
        // catch (ArithmeticException e)
        // {
        //     Console.WriteLine("Du fikk en ArithmeticException. De under skjer ikke.");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("Du fikk bare en generell Exception. Dette er moder Exceptionen");
        // }

        // Andre TRY-CATCH eksempel:
        StreamReader streamReader = null; // Definerer den utenfor try,catch og finally for at alle skal kunne nå den.
        try
        {
            streamReader = new StreamReader("/Users/jjberg/Github/learningDotnet/Advanced/ExceptionHandling/ExceptionHandling.cs");
            var content = streamReader.ReadToEnd();
            Console.WriteLine("Ting gikk bra");
        }
        catch (Exception e)
        {
            Console.WriteLine("Ting gikk ikke bra, men jeg har fortsatt ikke utført manuell garbage collection av StreamReaderen.");
        }
        finally
        {
            if (streamReader != null)
            {
                Console.WriteLine("streamReader er ikke null, og vi må drive manuell garbage collection");
                streamReader.Dispose(); // StreamReader er en unmanaged resource, fordi det har med filer å gjøre. Viktig å rydde hvis ting går gale.
            }
            Console.WriteLine("Uansett hva som skjer ovnenfor, om man havner i en try eller catch, ender man til slutt opp i finally.");
        }
    }
}