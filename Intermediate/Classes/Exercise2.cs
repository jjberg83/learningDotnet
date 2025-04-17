namespace Intermediate.Classes;
public class Exercise2
{
    public static void Run()
    {
        // string title = "What is the difference between .NET Core and .NET Framework?";
        // string title = "";
        string minTittel = null;
        // string description = "It seems to be the same, but I know it must be different, because my mentor told me";
        // string description = "";
        string minDescription = null;
        Post myFirstStackOverFlowPost = new Post(minTittel, minDescription);
        Console.WriteLine(myFirstStackOverFlowPost.CreationTimeStamp);
        Console.WriteLine(myFirstStackOverFlowPost.Title);
        Console.WriteLine(myFirstStackOverFlowPost.Description);
    }
}