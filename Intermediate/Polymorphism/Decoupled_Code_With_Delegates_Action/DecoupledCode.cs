namespace Intermediate.Polymorphism.Decoupled_Code_With_Delegates_Action;

internal class DecoupledCode
{
    public static void Run()
    {
        // I stedet for en liste med instanser av derived Shape classes (bruker inheritance i dette tilfelle,
        // men kunne like greit brukt interfaces), bruker jeg en delegate med Action (uten parametere)

        var canvas = new Canvas();

        Action myFirstDelegate = methodInMain;
        myFirstDelegate += Circle.Draw;
        canvas.Draw(myFirstDelegate);

        Console.WriteLine();

        Action mySecondDelegate = Square.Draw;
        mySecondDelegate += Triangle.Draw;
        canvas.Draw(mySecondDelegate);
    }

    public static void methodInMain()
    {
        Console.WriteLine("Draw something...");
    }
}

/*
Copilots bedømming av koden min:

What You’ve Done Well

Custom Delegate Usage:
You defined a custom delegate (Canvas.ShapeDelegate) and used it to encapsulate drawing behavior. 
This allows you to compose and invoke multiple methods dynamically, which is a flexible approach.

Decoupling:
By using delegates, you decouple the Canvas class from specific shape types. The Canvas only needs to know about 
the delegate, not about any specific shape classes.

Multicast Delegates:
You demonstrated combining multiple methods (e.g., myFirstDelegate += Circle.Draw;) to create a multicast delegate, 
showing how delegates can represent a chain of actions.

Clear Demonstration:
Your Run method clearly shows how to set up and use delegates, making it easy to follow and test.

Areas for Improvement

Type Safety and Discoverability:
While delegates are flexible, they lack the type safety and discoverability of interfaces or abstract classes. 
For example, with interfaces, you can enforce that all shapes implement a Draw() method, and you can pass around IShape references. 
With delegates, you lose this contract.

Extensibility:
If you want to add more shape-related behavior (e.g., Move, Resize), interfaces or inheritance scale better, as you can add 
more methods to the contract. With delegates, you’d need to define new delegates for each behavior.

Parameterization:
Your delegate has no parameters. If you wanted to pass information (like a color or position), you’d need to update the 
delegate signature and all methods using it. Interfaces and inheritance can encapsulate state more naturally.
*/