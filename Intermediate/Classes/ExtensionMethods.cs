using Shared;

namespace Intermediate.Classes;

public class ExtensionMethods
{
    public static void Run()
    {
        var bigNerdy = new CoderShared();
        bigNerdy.Strenghts = "Genious mastermind coder";
        bigNerdy.CertificationExpiry = new DateTime(2063, 07, 02);
        //Denne metoden finnes egentlig ikke i Coder klassen, men jeg har lagt den til som en extension
        bigNerdy.Reverse();
    }
}
