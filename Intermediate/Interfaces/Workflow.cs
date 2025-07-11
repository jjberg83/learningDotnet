namespace Intermediate.Interfaces;

public class Workflow : IWorkflow
{
    private readonly IList<IActivity> _activities;

    public Workflow()
    {
        _activities = new List<IActivity>();
    }

    // metoden under returnerer den private listen _activities,
    // men det eneste man kan gjøre er å loope gjennom den.
    // Man kan ikke kjøre dens metoder (activites.addActivity(activity) for eksempel)
    // Det vill eman kunne gjort med følgende signatur:
    // public List<IActivity> GetActivites()
    // Da returnerer man listen med alle dens metoder inkludert
    public IEnumerable<IActivity> GetActivities()
    {
        return _activities;
        // gammel kode (da hadde metoden ingen argumenter)
        // foreach (IActivity activity in _activities)
        // {
        //     activity.Execute();
        // }
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
