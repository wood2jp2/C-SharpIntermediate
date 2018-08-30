using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1___Design_a_Stopwatch
{
    class Message
    {
        public void DisplayMessage(Stopwatch stopwatch)
        {
            Console.WriteLine("Please type 'start' or 'stop' to invoke stopwatch");
            var reaction = Console.ReadLine();
            if (reaction == "start")
            {
                stopwatch.Start();
                DisplayMessage(stopwatch);
            }
            else if (reaction == "stop")
            {
                var duration = stopwatch.Stop();
                Console.WriteLine(duration);
                return;
            } else
            {
                DisplayMessage(stopwatch);
            }
        }
    }
}
