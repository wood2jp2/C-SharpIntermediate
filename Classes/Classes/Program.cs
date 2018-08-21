using System;

namespace Classes
{

    public class Person
    {
        public string Name;

        // methods on a class can contain a default value, which is 'blank' in this case
        public void Introduce(string to = "blank")
        {
            Console.WriteLine("Hello {0}, my name is {1}", to, Name);
        }
        public static int PeopleCount = 0;

        // this is static on the Person object, and returns a new instance of Person
        public static Person Parse(string str) 
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var Josh = new Person();
            Josh.Name = "Josh";
            Josh.Introduce("Ryan");

            // You CAN change a static value
            Person.PeopleCount = 32;
            Console.WriteLine("People count: " + Person.PeopleCount);

            var anotherPerson = Person.Parse("caitlin");
            anotherPerson.Introduce(Josh.Name);
        }
    }
}
