namespace Intermediate.Interfaces;

public class WorkflowEngine
{
    public void Run(List<IActivity> activities)
    {
        Console.WriteLine();
        foreach (IActivity activity in activities)
        {
            activity.Execute();
        }
        Console.WriteLine("--------------------------------------");
    }
}