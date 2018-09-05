
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("car something");
        }

        public Car(string registrationNumber) //: base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized, registration number: {0}", registrationNumber);
        }
    }
}
