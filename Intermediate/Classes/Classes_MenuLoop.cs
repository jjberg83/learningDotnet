namespace Intermediate.Classes;
public class Classes_MenuLoop
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
                case "Methods":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Methods");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Methods.Run();
                    break;
                case "ObjectInitializers":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting ObjectInitializers.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    ObjectInitializers.Run();
                    break;
                case "IntroductionToClasses":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting IntroductionToClasses.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    IntroductionToClasses.Run();
                    break;
                case "Constructors":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Constructors.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Constructors.Run();
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