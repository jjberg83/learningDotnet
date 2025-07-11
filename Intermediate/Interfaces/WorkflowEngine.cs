namespace Intermediate.Interfaces;

public class WorkflowEngine
{
    // Mitt forslag
    // public void Run(List<IActivity> activities)
    // {
    //     Console.WriteLine();
    //     foreach (IActivity activity in activities)
    //     {
    //         activity.Execute();
    //     }
    //     Console.WriteLine("--------------------------------------");
    // }

    // Instruktørs forslag
    public void Run(Workflow workflow)
    {
        Console.WriteLine();
        foreach (IActivity activity in workflow.GetActivities())
        {
            activity.Execute();
        }
        Console.WriteLine("--------------------------");
    }

    /*
    Jeg spurte Copilot følgende spørsmål:
    If you look at Exercise.cs, WorkflowEngine.cs and Workflow.cs, do you agree or disagree with the following:
    Do not use a WorkflowEngine.cs class, and instead move the method inside this class into Workflow. 
    Looping through this list of activities is something that should be encapsulated inside a Workflow.

    Copilot sitt svar:
    I disagree with moving the method from [WorkflowEngine]WorkflowEngine.cs ) into [Workflow]Workflow.cs ).
    Here’s why:

    Separation of Concerns
    The [Workflow]Workflow.cs ) class should be responsible for managing the collection of activities 
    (adding, removing, exposing them). The [WorkflowEngine]WorkflowEngine.cs ) class should be responsible for executing 
    the workflow (i.e., running all activities in order).
    Why Keep WorkflowEngine?
    Encapsulation: [Workflow]Workflow.cs ) is a data structure; [WorkflowEngine]WorkflowEngine.cs ) is a process.
    Single Responsibility Principle: Each class has one reason to change. [Workflow]Workflow.cs ) changes if the 
    way you store activities changes; [WorkflowEngine]WorkflowEngine.cs ) changes if the way you execute workflows changes.
    Extensibility: You can easily extend [WorkflowEngine]WorkflowEngine.cs ) to support logging, error handling, 
    parallel execution, etc., without modifying [Workflow]Workflow.cs ).
    Industry Practice
    This separation is common in workflow, pipeline, and engine patterns.
    For example, in ASP.NET Core, the pipeline is configured separately from the engine that runs it.

    Summary:

    Keep [WorkflowEngine]WorkflowEngine.cs ) for running workflows.
    Keep [Workflow]Workflow.cs ) for managing activities.
    This design is more flexible, maintainable, and follows clean code principles.

    Jeg spurte følgende oppfølgingsspørsmål:
    This makes me a bit confused. I always thought that was how we were supposed to think about methods, with the 
    single responsibility feature. It makes me a bit confused because I know start wondering if I cannot have 
    classes with both methods and fields/properties any more. In that case, I know think I have to split them 
    up into two classes, one class for the data and one for the behaviour? If that is not true, how do I know 
    when to keep classes with both data and behaviour, and when not to?

    Copilot svarte:
    This is a great question and a common point of confusion when learning about Single Responsibility Principle (SRP) and separation of concerns.

You do NOT always need to split data and behavior into separate classes.
When to Keep Data and Behavior Together
Most classes in object-oriented programming have both data (fields/properties) and behavior (methods).
For example, a Car class might have properties like Speed and methods like Drive().
If the behavior is directly related to the data and represents what the object "does," it belongs in the same class.
When to Separate Data and Behavior
Separate behavior when it represents a process or operation that acts on multiple objects or coordinates complex workflows.
For example, a WorkflowEngine is responsible for running a workflow (a process), while Workflow is responsible for managing a collection of activities (data).
This separation makes your code more flexible, testable, and maintainable.
How to Decide?
Ask yourself:

Does the method represent what the object "is" or "does"?
If yes, keep it in the same class.
Does the method represent a process that acts on or coordinates multiple objects?
If yes, consider separating it into a different class (like an engine, manager, or service).
Examples
Order class: Has data (OrderId, Items) and behavior (CalculateTotal()).
OrderProcessor class: Has behavior (ProcessOrder(Order order)) that coordinates multiple objects.
Summary
Most classes will have both data and behavior.
Separate process/coordination logic into its own class when it makes sense for clarity and maintainability.
SRP means a class should have one reason to change, not that it must have only data or only behavior.
You do NOT need to split every class into a data class and a behavior class.
Use separation when it improves clarity, flexibility, or testability.
    */
}