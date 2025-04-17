namespace Intermediate.Classes;

    // Design a class called Post. This class models a StackOverflow post. It should have properties
    // for title, description and the date/time it was created. We should be able to up-vote or down-vote
    // a post. We should also be able to see the current vote value. In the main method, create a post,
    // up-vote and down-vote it a few times and then display the the current vote value.
    // In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
    // and down-voting. You should not give the ability to set the Vote property from the outside,
    // because otherwise, you may accidentally change the votes of a class to 0 or to a random
    // number. And this is how we create bugs in our programs. The class should always protect its
    // state and hide its implementation detail.

    // Educational tip: The aim of this exercise is to help you understand that classes should
    // encapsulate data AND behaviour around that data. Many developers (even those with years of
    // experience) tend to create classes that are purely data containers, and other classes that are
    // purely behaviour (methods) providers. This is not object-oriented programming. This is
    // procedural programming. Such programs are very fragile. Making a change breaks many parts
    // of the code.
public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    // private gjør at man kun kan gi en verdi i konstruktøren
    // Jeg vil at dette skal skje uten at bruker vet om det
    // og trenger å gjøre noenting som helst
    public DateTime CreationTimeStamp { get; private set; }

    public Post(string title, string description)
    {
        CreationTimeStamp = DateTime.Now;

        // Validation of arguments
        if(String.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be null, empty or whitespace", nameof(title));
        if(String.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be null, empty or whitespace", nameof(description));
        
        Description = description;
        Title = title;
        
    }


}
