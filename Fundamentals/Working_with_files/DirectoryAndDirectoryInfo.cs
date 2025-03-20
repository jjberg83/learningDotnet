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

        // La meg nå gjøre det samme med DirectoryInfo (som ikke er en statisk metode,
        // som betyr at man må lage instanser). OSet autentiserer kun når man lager
        // instansen, som gjør det mye raskere hvis man f.eks bruker DirectoryInfo
        // inni en megalang loop.

        // CreateDirectory, skriv inni filen med StreamWriter, GetFiles, GetDirectory og DirectoryExist
        // Man lager instans av folderen man vil lage subdirectories inni
        DirectoryInfo anotherNewDirectory = new DirectoryInfo(root); 
        anotherNewDirectory.CreateSubdirectory("EndaEtNyttDirectory");
        

        using(StreamWriter sw = new StreamWriter(root + "/EndaEtNyttDirectory/Min_Nye_Fil.txt"))
        {
            sw.WriteLine("// Mac er best!");
        }
        FileInfo[] files2 = anotherNewDirectory.GetFiles("*.txt*", SearchOption.AllDirectories);

        Console.WriteLine("##############################");
        Console.WriteLine("Fil opplistning gjort med DirectoryInfo instans");
        Console.WriteLine("##############################");

        foreach(FileInfo file in files2)
        {
            Console.WriteLine(file);
        }

        Console.WriteLine("##############################");
        Console.WriteLine("Folder opplistning gjort med DirectoryInfo instans");
        Console.WriteLine("##############################");

        DirectoryInfo[] directories2 = anotherNewDirectory.GetDirectories("*.*", SearchOption.AllDirectories);
        foreach(DirectoryInfo directory in directories2)
        {
            Console.WriteLine(directory);
        }

        Console.WriteLine($"Eksisterer {root}: {anotherNewDirectory.Exists}");
        // La meg prøve å få linjen over til å bli falsk
        // Må først lage en instans, men går det an hvis folderen ikke finnes?
        // Ja! Fordi jeg har ikke laget det med subdirectory. Jeg lager instansen av noe som ikke eksisterer! Bisart...

        DirectoryInfo NonExistentDirectory = new DirectoryInfo(root + "/ikke_eksisterende");
        Console.WriteLine($"Eksisterer {root}/ikke_eksisterende: {NonExistentDirectory.Exists}");


    }
}