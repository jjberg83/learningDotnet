using System.Runtime.InteropServices;

namespace Intermediate.Classes;

public class Indexers
{
    public static void Run()
    {
        Coder benjamin = new Coder();
        benjamin.Strenghts = "Drawing code ideas on a whiteboard";
        // Jeg begynner å se fordelen med indexers for Properties
        // Man kan definere det som på frontenden ser ut som at man bare lager nye Properties
        // Men som i virkeligheten bare er innslag i en dictionary. Tøft. Det samme kan man ikke
        // gjøre med Propertien Strengths over. Da vil man bare overskrive. Det finnes bare en instans.
        Console.WriteLine($"benjamin.Strenghts: {benjamin.Strenghts}");
        benjamin.Strenghts = "Genious brain";
        Console.WriteLine($"benjamin.Strenghts: {benjamin.Strenghts}");

        // Hvordan best consolewrite fra en property indexer?
        benjamin["codeIdea"] = "Fix the world. Starting with UiS";
        benjamin["tiredOfHearing"] = "Bro...skal vi ta en runde FIFA eller?";

        Console.WriteLine($"benjamin[\"codeIdea\"]:  {benjamin["codeIdea"]}");
        Console.WriteLine($"benjamin[\"tiredOfHearing\"]:  {benjamin["tiredOfHearing"]}");

        // Kan man loope igjennom?
        // Yes, men Github Copilot ville man skulle lage en metode for det inni klassen som jeg her bruker.
        foreach(KeyValuePair<string,string> element in benjamin.GetAllEntries())
        {
            Console.WriteLine(element.ToString()); 
        }

        benjamin.CertificationExpiry = new DateTime(2026, 02, 15);
        Console.WriteLine($"Benjamins certification will expire on {benjamin.CertificationExpiry}");
    }
}