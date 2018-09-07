
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    public class Car : Vehicle
    {
        // if you run this, but comment out public Vehicle() in that class, it will throw an error
        // The always attempts to create first an object of type Vehicle.
        public Car() : base()
        {
            Console.WriteLine("car something");
        }

        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized, registration number: {0}", registrationNumber);
        }
    }
}
