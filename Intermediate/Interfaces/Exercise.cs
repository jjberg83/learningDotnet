namespace Intermediate.Interfaces;

// UploadVideo
// CallWebService
// ChangeStatus
// SendEmail

public class Exercise
{
    public static void Run()
    {
        List<IActivity> workflow_1 = new() { new UploadVideo(), new SendEmail() };
        List<IActivity> workflow_2 = new() { new CallWebService(), new UploadVideo(), new ChangeStatus() };
        List<IActivity> workflow_3 = new() { new SendEmail(), new CallWebService(), new UploadVideo(), new ChangeStatus() };

        var workflowEngine = new WorkflowEngine();
        workflowEngine.Run(workflow_1);
        workflowEngine.Run(workflow_2);
        workflowEngine.Run(workflow_3);
    }
}