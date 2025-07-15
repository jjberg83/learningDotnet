namespace Intermediate.AssociationBetweenClasses;
public class AssociationBetweenClasses_MenuLoop
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
                case "ValidationLogicExamples":
                    Console.WriteLine();

                    // Eksempel med auto-implemented property og egen metode for validering
                    TreeOne treeOne = new TreeOne();
                    // Denne feiler
                    // treeOne.SetHeight(-1);
                    // Mens denne er OK
                    treeOne.SetHeight(12);
                    Console.WriteLine($"Treets høyde er {treeOne.Height}");

                    // Eksempel med auto-implemented property og validering i constructoren
                    // Denne feiler
                    // TreeTwo treeTwo = new TreeTwo(-1);
                    TreeTwo treeTwo = new TreeTwo(13);
                    Console.WriteLine($"Treets høyde er {treeTwo.Height}");

                    // Eksempel med valideringen direkte i setteren
                    // siden man endrer en av get og set (i dette tilfellet set)
                    // må begge endres. Man kan ikke bare skrive get; eller set;
                    TreeThree treeThree = new TreeThree();
                    // Denne feiler
                    // treeThree.Height = -1;
                    // Denne er mulig. Setteren har ikke private foran, og logikken inni setteren godkjenner denne
                    treeThree.Height = 14;
                    Console.WriteLine($"Treets høyde er {treeThree.Height}");


                    break;
                case "CompositionOverInheritance":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("CompositionOverInheritance");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    CompositionOverInheritance.Run();
                    break;
                case "Composition":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Composition");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Composition.Run();
                    break;
                case "Inheritance":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Inheritance");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    Inheritance.Run();
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