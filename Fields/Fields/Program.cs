using System;
using System.Collections.Generic;

namespace Fields
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var Josh = new Athlete() { Sport = "Baseball", Position = "2 base" };
            List<Athlete> Athletes = new List<Athlete>() { Josh };
            Athletes.Add(new Athlete() { Number = 42, Sport="Basketball", Position="Guard"});
            Console.WriteLine(Athletes[1].Sport);
        }
    }
}
