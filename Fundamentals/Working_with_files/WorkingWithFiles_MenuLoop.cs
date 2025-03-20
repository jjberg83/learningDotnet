namespace Fundamentals.Working_with_files;

public class WorkingWithFiles_MenuLoop
{
    public static void Run()
    {
        
        bool loopButton = true;
        while (loopButton)
        {
            Console.WriteLine("##################");
            Console.WriteLine("Please choose an exercise between 1-5 OR the name of the file you want to run (type 'Exit' to stop)");
            Console.WriteLine("##################");
            Console.WriteLine();

            string? userInput = Console.ReadLine();
            
            switch(userInput)
            {
                case "FileAndFileInfo":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting FileAndFileInfo.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    FileAndFileInfo.Run();
                    break;
                case "DirectoryAndDirectoryInfo":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting DirectoryAndDirectoryInfo.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    DirectoryAndDirectoryInfo.Run();
                    break;
                case "Path":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Path.cs");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    PathI.Run();
                    break;
                case "1":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Exercise 1");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    WorkingWithFiles_Exercises.Exercise1();
                    break;
                case "2":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Exercise 2");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    WorkingWithFiles_Exercises.Exercise2();
                    break;
                case "3":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Exercise 3");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    WorkingWithFiles_Exercises.Exercise3();
                    break;
                case "4":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Exercise 4");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    WorkingWithFiles_Exercises.Exercise4();
                    break;
                case "5":
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Starting Exercise 5");
                    Console.WriteLine("-----------------");
                    Console.WriteLine();
                    WorkingWithFiles_Exercises.Exercise5();
                    break;
                case "Exit":
                case "exit":
                    Console.WriteLine("Stopping program...");
                    loopButton = false;
                    break;
                default:
                    Console.WriteLine("You did not write a number between 1-5. Program stopping...");
                    loopButton = false;
                    break;
            }
        }
    }
}
