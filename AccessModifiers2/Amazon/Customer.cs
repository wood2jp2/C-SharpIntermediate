using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // Usually not good practice to instantiate a new object from within a method. Creates coupling / dependency
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

        }
    }
}
