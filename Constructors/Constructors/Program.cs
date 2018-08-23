using System;

namespace Constructors
{
    public class Person
    {

        //methods and members should probably be instantiated outside of constructor.
        public string Name;

        public void Introduce()
        {
            Console.WriteLine("Hi" + Name);
        }

        // The below instantiates the constructor
        public Person(string name)
        {
            this.Name = name;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var Josh = new Customer();
            Console.WriteLine(Josh.Id);
            // if you put a break / watch here, note that the defaults for ints is 0, and for strings is null
            Console.WriteLine(Josh.Name);

            var John = new Customer(1, "John");
        }
    }
}
