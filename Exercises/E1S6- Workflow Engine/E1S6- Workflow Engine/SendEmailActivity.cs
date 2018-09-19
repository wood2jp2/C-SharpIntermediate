using System;

namespace E1S6__Workflow_Engine
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("sending an email...");
        }
    }
}
