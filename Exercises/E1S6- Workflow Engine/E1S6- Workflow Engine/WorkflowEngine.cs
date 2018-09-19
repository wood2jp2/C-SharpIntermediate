namespace E1S6__Workflow_Engine
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var process in workflow.ListOfActivities)
            {
                process.Execute();
            }
        }
    }
}
