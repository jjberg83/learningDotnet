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
        workflow.Run();
        Console.WriteLine("--------------------------");
    }
}