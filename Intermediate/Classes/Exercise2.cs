namespace Intermediate.Classes;
public class Exercise2
{
    public static void Run()
    {
        Post myFirstPost = new Post("Lærer om readonly og private set", "Hva er forskjellen?");
        Console.WriteLine(myFirstPost.Title);
        Console.WriteLine(myFirstPost.Description);
        Console.WriteLine(myFirstPost.CreationTimeStamp);
        Console.WriteLine(myFirstPost.VoteValue);
        myFirstPost.Upvote();
        myFirstPost.Upvote();
        myFirstPost.Upvote();
        myFirstPost.Downvote();
        Console.WriteLine(myFirstPost.VoteValue);

    
        


        // Post myFirstPost;
        // while(true)
        // {
        //     try
        //     {
        //         Console.WriteLine("Please write the title of your StackOverflow post:");
        //         string? userTitle = Console.ReadLine();
        //         Console.WriteLine("Please write your issue/question:");
        //         string? userQuestion = Console.ReadLine();
        //         myFirstPost = new Post(userTitle, userQuestion);
        //         Console.WriteLine($"StackOverflow post successfully created on {myFirstPost.CreationTimeStamp}");
        //         Console.WriteLine($"Title: {myFirstPost.Title}");
        //         Console.WriteLine($"Issue/Question: {myFirstPost.Description}");
        //         break;
        //     }
        //     catch(Exception e)
        //     {  
        //         Console.WriteLine(e.Message);
        //         Console.WriteLine("Please try submitting again.");
        //     }
        // }

        // Console.WriteLine("Trying to reconnect to my variable....");
        // Console.WriteLine($"{myFirstPost.CreationTimeStamp}, {myFirstPost.Title}");
        // myFirstPost.Title = "Hey, I changed my title!";
        // Console.WriteLine($"{myFirstPost.CreationTimeStamp}, {myFirstPost.Title}");
        // Console.WriteLine($"{myFirstPost.CreationTimeStamp}, {myFirstPost.VoteValue}");



    }
}