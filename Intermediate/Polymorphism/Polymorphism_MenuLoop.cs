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

            switch (userInput.ToLower())
            {
                case "abstractclassesandmembers":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("AbstractClassesAndMembers");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    AbstractClassesAndMembers.Run();
                    break;
                case "decoupledcode":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("DecoupledCode");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Decoupled_Code.DecoupledCode.Run();
                    break;
                case "coupledcode":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("CoupledCode");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Coupled_Code.CoupledCode.Run();
                    break;
                case "methodoverriding":
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