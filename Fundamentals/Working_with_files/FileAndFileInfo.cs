
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
        File.Copy(root + "WorkingWithFiles_Exercises.cs", root + "WorkingWithFiles_Exercises_Copy.cs", true);
        if(File.Exists(root + "WorkingWithFiles_Exercises_Copy.cs"))
        {
            Thread.Sleep(3000);
            File.Delete(root + "WorkingWithFiles_Exercises_Copy.cs");
        }

        // Nå skal vi laste inn et sitat fra en variabel inn i en fil.
        string joshWaitzkinSitat = "The key to pursuing excellence is to embrace an organic, long-term learning process, and not to live in a shell of static, safe mediocrity. Usually, growth comes at the expense of previous comfort or safety. ― Josh Waitzkin, The Art of Learning: A Journey in the Pursuit of Excellence";

        // Vi gir navnet på ny fil som argument til ny StreamWriter
        // Den virker til å ta utgantspunkt fra hvor Program.cs ligger, altså i Fundamentals mappen
        using (StreamWriter sw = new StreamWriter("./Working_with_files/SamlingSitater.txt")) 
        {
            sw.WriteLine(joshWaitzkinSitat);
        }
        // Her laster vi tekst fra denne filen inn i en ny variabel
        string joshWaitzkinQuote = File.ReadAllText(root + "SamlingSitater.txt"); // Laster det bare inn i variabelen
        Console.WriteLine(joshWaitzkinQuote);
        Console.WriteLine();

        // Så FileInfo, der sikkerhetssjekken gjøres kun når man oppretter instansen

        // FileInfo original = new FileInfo(root + "WorkingWithFiles_Exercises.cs");
        // original.CopyTo(root + "WorkingWithFiles_Exercises_Copy.cs", true);
        // FileInfo copy = new FileInfo(root + "WorkingWithFiles_Exercises_Copy.cs");

        // if (copy.Exists)
        // {
        //     Thread.Sleep(3000);
        //     copy.Delete();
        // }

        // FileInfo fileToLoadTextFrom = new FileInfo(root + "SamlingSitater.txt"); 
        // System.IO.FileStream joshWaitzkinQuote = fileToLoadTextFrom.OpenRead(); // Han sa denne var litt kompleks, og han har rett....
    }
}