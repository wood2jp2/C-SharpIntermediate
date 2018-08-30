using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1___Design_a_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var mess = new Message();
            mess.DisplayMessage(watch);
        }
    }
}
