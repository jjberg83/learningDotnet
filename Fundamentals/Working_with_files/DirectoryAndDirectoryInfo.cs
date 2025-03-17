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
        Directory.GetFiles(root, ".cs", SearchOption.AllDirectories);
    }
}