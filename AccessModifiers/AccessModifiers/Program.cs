using System;

namespace AccessModifiers
{

    public class Person {
        private DateTime _birthdate; // can't access outside of Person class.

        public DateTime GetBirthdate() {
            return _birthdate;
        }

        public void SetBirthdate(DateTime birthdate) {
            _birthdate = birthdate;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            var josh = new Person();
            // Console.WriteLine(josh._birthdate); doesn't return anything since this is private field

            josh.SetBirthdate(new DateTime(1992, 11, 12));
            Console.WriteLine(josh.GetBirthdate());
        }
    }
}
