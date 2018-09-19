using System;

namespace E1S6__Workflow_Engine
{
    public class CallingWebServiceActivity : IActivity
    {
        public void Execute() => Console.WriteLine("Calling a web service");
    }
}
