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
   
    // FORSKJELL PÅ READONLY OG PRIVATE SET (se readonly brukt på _CreationTimeStamp)
    // readonly kan kun brukes på fields og sikrer at fieldet kun kan gis verdi her eller i konstruktøren (og aldri endres etterpå)
    // Ved å opprette en property oppå det private fieldet, og kun lage en get metode, ingen set, 
    // sikrer man at denne verdien aldri kan endres. Man må da eksplisitt skrive det private fieldet, slik at man 
    // kan skrive readonly foran. Dette fieldet er jo automatisk generert og skjult når man bare bruker shortcuten
    // med å lage en property.
    // private set i en property gjør at koden ikke kan endres direkte i andre klasser slik MyPost.CreationTimeStamp = noe
    // For å sette den fra andre klasser må man bruke en metode man lager inni Post klassen
public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    private readonly DateTime _creationTimeStamp;
    public DateTime CreationTimeStamp { 
        get
        {
            return _creationTimeStamp;
        } 
    }
    public int VoteValue { get; private set; }

    public Post(string title, string description)
    {
        _creationTimeStamp = DateTime.Now;

        // Validation of arguments (exceptions håndteres i RUN() metoden for Exercise2.cs)
        if(String.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be null, empty or whitespace", nameof(title));
        if(String.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be null, empty or whitespace", nameof(description));
        
        Description = description;
        Title = title;
        
    }

    public void Upvote()
    {
        VoteValue += 1;
    }

    public void Downvote()
    {
        VoteValue -= 1;
    }


}
