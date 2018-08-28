using System;
namespace Properties
{
    public class Person
    {

        //private DateTime _birthdate;

        // LONG WAY TO DECLARE - getters and setters

        //public DateTime GetBirthdate() {
        //    return _birthdate;
        //}

        //public void SetBirthdate(DateTime birthdate) {
        //    _birthdate = birthdate;
        //}

        // SHORT WAY TO DECLARE - getters and setters

            //public DateTime Birthdate {
            //get { return _birthdate; }
            //set { _birthdate = value; }
            //}
           
        // EVEN SHORTER WAY TO DECLARE - getters and setters

        public DateTime Birthdate { get; private set; } // C# compiler automatically generates a private field here
        // with the 'private' set, you now cannot set the Birthdate inside the code, and must use ctor

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


        public int Age {
            get {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
            // no 'set' method since the Age is being calculated and should not be set manually

        }

        public string Name
        {
            get;
            set;
        }

        // type faster properties with 'prop' + tab

        public string UserName
        {
            get;
            set;
        }

    }
}
