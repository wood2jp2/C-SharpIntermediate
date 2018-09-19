using System.Collections.Generic;

namespace E1S6__Workflow_Engine
{
    public class Workflow
    {
        public IList<IActivity> ListOfActivities = new List<IActivity>();

        //public Workflow(IActivity activity)
        //{
        //    ListOfActivities.Add(activity);
        //}

        public void AddActivity(IActivity activity)
        {
            ListOfActivities.Add(activity);
        }

    }
}
