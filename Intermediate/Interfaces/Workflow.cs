namespace Intermediate.Interfaces;

public class Workflow : IWorkflow
{
    private readonly IList<IActivity> _activities;

    public Workflow()
    {
        _activities = new List<IActivity>();
    }

    public void Run()
    {
        foreach (IActivity activity in _activities)
        {
            activity.Execute();
        }
    }

    public void addActivity(IActivity activity)
    {
        _activities.Add(activity);
    }

    public void removeActivity(int index)
    {
        if (_activities.Count() == 0)
            Console.WriteLine("Det finnes ingen flere aktiviteter i workflowen å fjerne.");

        else
            _activities.RemoveAt(index);
    }
}
