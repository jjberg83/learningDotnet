namespace Intermediate.Inheritance;
public class Inheritance_MenuLoop
{
    public static void Run()
    {
        bool loopButton = true;
        while (loopButton)
        {
            Console.WriteLine("##################");
            Console.WriteLine("Please choose the name of the file you want to run (type 'Exit' to stop)");
            Console.WriteLine("##################");
            Console.WriteLine();

            string? userInput = Console.ReadLine();
            
            switch(userInput)
            {
                case "BoxingAndUnboxing":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("BoxingAndUnboxing");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    BoxingAndUnboxing.Run();
                    break;
                case "UpcastingAndDowncasting":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("UpcastingAndDowncasting");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    UpcastingAndDowncasting.Run();
                    break;
                case "ConstructorsAndInheritance":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("ConstructorsAndInheritance");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    ConstructorsAndInheritance.Run();
                    break;
                case "AccessModifiers":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("AcessModifiers");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    AccessModifiers.Run();
                    break;
                case "exit":
                    Console.WriteLine("Stopping program...");
                    loopButton = false;
                    break;
                default:
                    Console.WriteLine("You did not write a file name or an exercise number. Program stopping...");
                    loopButton = false;
                    break;
            }
        }
    }
}