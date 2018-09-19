using System.Collections.Generic;

namespace E1S6__Workflow_Engine
{

    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
    }

    public class Workflow : IWorkflow
    {
        public IList<IActivity> _listOfActivities = new List<IActivity>();

        public void Add(IActivity activity) => _listOfActivities.Add(activity);

        public void Remove(IActivity activity) => _listOfActivities.Remove(activity);
    }
}
