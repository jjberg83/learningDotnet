namespace Intermediate.Interfaces;

public interface IWorkflow
{
    void addActivity(IActivity activity);
    void removeActivity(int index);
    void Run();
}
