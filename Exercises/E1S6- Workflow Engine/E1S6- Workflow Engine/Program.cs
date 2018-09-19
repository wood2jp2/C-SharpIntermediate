using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1S6__Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            workflow.AddActivity(new ChangeStatusActivity());
            workflow.AddActivity(new SendEmailActivity());

            workflowEngine.Run(workflow);
        }
    }
}
