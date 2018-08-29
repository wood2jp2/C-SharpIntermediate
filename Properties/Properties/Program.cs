using System;

namespace Properties
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var josh = new Person(new DateTime(1992, 11, 12));
            //josh.Birthdate = new DateTime(1992, 11, 12);can't use this code with private set
            josh.UserName = "username";
            Console.WriteLine(josh.UserName);
        }
    }
}
