namespace Intermediate.Interfaces;

// UploadVideo
// CallWebService
// ChangeStatus
// SendEmail
public class Exercise
{
    public static void Run()
    {
        // Mitt forslag
        // List<IActivity> workflow_1 = new() { new UploadVideo(), new SendEmail() };
        // List<IActivity> workflow_2 = new() { new CallWebService(), new UploadVideo(), new ChangeStatus() };
        // List<IActivity> workflow_3 = new() { new SendEmail(), new CallWebService(), new UploadVideo(), new ChangeStatus() };

        // var workflowEngine = new WorkflowEngine();
        // workflowEngine.Run(workflow_1);
        // workflowEngine.Run(workflow_2);
        // workflowEngine.Run(workflow_3);

        // Instruktørs forslag (i stedet for en liste som over, lage en egen Workflow klasse)
        Workflow workflow_1 = new();
        workflow_1.addActivity(new UploadVideo());
        workflow_1.addActivity(new SendEmail());

        var workflow_2 = new Workflow();
        workflow_2.addActivity(new CallWebService());
        workflow_2.addActivity(new UploadVideo());
        workflow_2.addActivity(new ChangeStatus());

        var workflowEngine = new WorkflowEngine();
        workflowEngine.Run(workflow_1);
        workflowEngine.Run(workflow_2);

    }
}