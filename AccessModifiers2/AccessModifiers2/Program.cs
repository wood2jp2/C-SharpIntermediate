using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            // cannot now access RateCalculator on its own. Since it is set to internal,
            // it can only be accessed by things from the same assembly
            Amazon.RateCalculator = new RateCalculator();
        }
    }
}
