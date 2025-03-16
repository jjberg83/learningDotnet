
namespace Fundamentals.Working_with_files;

public class FileAndFileInfo
{
    public static void Run()
    {
        // File er static og derfor enklere. Ulempen er at OSet gjør
        // sikkerhetssjekker hver gang jeg bruker noen metoder, som gjør
        // det tregt hvis jeg gjør bruker dem mye. Da er FileInfo bedre.
        // Her må man opprette instanser, men sikkerhetssjekken gjøres 
        // bare en gang. Først File, som er statisk.

        string root = "/Users/jjberg/Github/learningDotnet/Fundamentals/Working_with_files/";
        // File.Copy(root + "WorkingWithFiles_Exercises.cs", root + "WorkingWithFiles_Exercises_Copy.cs", true);
        // if(File.Exists(root + "WorkingWithFiles_Exercises_Copy.cs"))
        // {
        //     Thread.Sleep(3000);
        //     File.Delete(root + "WorkingWithFiles_Exercises_Copy.cs");
        // }
        // string joshWaitzkinQuote = File.ReadAllText(root + "joshWaitzkin.txt"); // Laster det bare inn i variabelen
        // Console.WriteLine(joshWaitzkinQuote);
        // Console.WriteLine();

        // Så FileInfo, der sikkerhetssjekken gjøres kun når man oppretter instansen

        FileInfo original = new FileInfo(root + "WorkingWithFiles_Exercises.cs");
        original.CopyTo(root + "WorkingWithFiles_Exercises_Copy.cs", true);
        FileInfo copy = new FileInfo(root + "WorkingWithFiles_Exercises_Copy.cs");

        if (copy.Exists)
        {
            Console.WriteLine("Kopi skal eksistere");
            // Console.WriteLine("Kopi slettes...");
            // Thread.Sleep(3000);
            // copy.Delete();
        }

        // FileInfo fileToLoadTextFrom = new FileInfo(root + "joshWaitzkin.txt"); 
        // System.IO.FileStream joshWaitzkinQuote = fileToLoadTextFrom.OpenRead(); // Han sa denne var litt kompleks, og han har rett....

        string joshWaitzkinQuote = File.ReadAllText(root + "joshWaitzkin.txt"); // Laster det bare inn i variabelen
        Console.WriteLine(joshWaitzkinQuote);
        Console.WriteLine();
    }
}