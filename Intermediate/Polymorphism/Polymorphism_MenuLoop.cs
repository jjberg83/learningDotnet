namespace Intermediate.Polymorphism;
internal class Polymorphism_MenuLoop
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

            switch (userInput)
            {
                case "MethodOverriding":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("MethodOverriding");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    MethodOverriding.Run();
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