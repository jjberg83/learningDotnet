using System.Collections;

namespace Intermediate.Classes;
public class Exercise1
{
    public static void Run()
    {
        Stopwatch stoppeKlokke = new Stopwatch();
        bool fortsettTidtakning = true;
        Console.WriteLine("-------------------");
        Console.WriteLine("Stoppeklokke program startet!");
        Console.WriteLine("Skriv følgende for å bruke stoppeklokken:");
        Console.WriteLine("START = start en ny runde på stoppeklokken");
        Console.WriteLine("STOPP = stopp runden du allerede har startet");
        Console.WriteLine("SLUTT = slutt stoppeklokke progammet");
        Console.WriteLine("-------------------");
        Console.WriteLine();
        string? userInput;
        while(fortsettTidtakning)
        {
            userInput = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Husk å skrive enten START, STOPP eller SLUTT");
                continue;
            }
        
            userInput = userInput.ToUpper();
            
            switch(userInput)
            {
                case "START":
                    stoppeKlokke.Start();
                    break;
                case "STOPP":
                    stoppeKlokke.Stop();
                    break;
                case "SLUTT":
                    fortsettTidtakning = false;
                    stoppeKlokke.Slutt();
                    Console.WriteLine("Stoppeklokkeprogram avsluttes...");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Du har ikke skrevet enten START, STOPP eller SLUTT");
                    break;
            }
        }
    }
}