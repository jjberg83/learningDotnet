using System.Runtime.InteropServices;

namespace Intermediate.Classes;

public class AccessModifier
{
    public static void Run()
    {
        var person1 = new PersonPrivat();
        DateTime bursdag = new DateTime(1983, 07, 02);
        Console.WriteLine(person1.GetBirthdate()); 
        person1.SetBirthdate(bursdag);
        Console.WriteLine(person1.GetBirthdate()); 

    }
}
