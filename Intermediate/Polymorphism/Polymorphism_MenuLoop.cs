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

            /* Valgene jeg har:
            SealedClassesAndMembers
            AbstractClassesAndMembers
            DecoupledCode
            CoupledCode
            MethodOverriding
            DatabaseConnection
            */

            string? userInput = Console.ReadLine();

            if (string.Equals(userInput, "exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Stopping program...");
                break;
            }

            string className = $"Intermediate.Polymorphism.{userInput}";

            Type? type = Type.GetType(className);

            if (type != null)
            {
                var runMethod = type.GetMethod("Run", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                if (runMethod != null)
                {
                    runMethod.Invoke(null, null);
                }
                else
                {
                    Console.WriteLine($"Class '{userInput}' does not have a static Run() method");
                }
            }
            else
            {
                Console.WriteLine($"Could not find a class named '{userInput}'");
            }

        }
    }
}