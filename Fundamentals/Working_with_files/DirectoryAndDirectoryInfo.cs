namespace Fundamentals.Working_with_files;

class DirectoryAndDirectoryInfo
{
    public static void Run()
    {
        string root = "/Users/jjberg/Github/learningDotnet/Fundamentals/Working_with_files";
        Directory.CreateDirectory(root + "/Directory_skapt_i_VSCode");
        // Så går vi inn i directory vi nettopp skapet, og lager en ny fil, med en kommetar inni
        using(StreamWriter sw = new StreamWriter(root + "/Directory_skapt_i_VSCode/Fil_laget_i_VSCode.cs"))
        {
            // Her kommer innholdet i filen
            sw.WriteLine("// Bare en kommentar foreløpig");
        }
        // string[] files = Directory.GetFiles(root + "/", ".cs", SearchOption.AllDirectories);
        // (parameter 1: hvilket directory, noen spesielle filer?, rekursivt?)
        string[] files = Directory.GetFiles(root ,"*.cs*", SearchOption.AllDirectories);
        
        foreach(string file in files)
        {
            Console.WriteLine(file);
        }

        // Så gjør vi akkurat det samme for Directories
        string[] directories = Directory.GetDirectories(root, "*.*", SearchOption.AllDirectories);

        Console.WriteLine("#############################");
        foreach(string directory in directories)
        {
            Console.WriteLine(directory);
        }

        bool mappe1Finnes = Directory.Exists(root + "/Directory_skapt_i_VSCode");
        bool mappe2Finnes = Directory.Exists(root + "/Directory_som_ikke_finnes");
        Console.WriteLine($"Finnes {root}/Directory_skapt_i_VSCode? {mappe1Finnes}");
        Console.WriteLine($"Finnes {root}/Directory_som_ikke_finnes? {mappe2Finnes}");

    }
}