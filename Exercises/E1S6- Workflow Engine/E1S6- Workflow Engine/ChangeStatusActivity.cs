using System;

namespace E1S6__Workflow_Engine
{
    public class ChangeStatusActivity : IActivity
    {
        public void Execute() => Console.WriteLine("changing status of video record");
    }
}
