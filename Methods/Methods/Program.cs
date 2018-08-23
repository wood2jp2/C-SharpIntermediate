using System;
using System.Linq;

namespace Methods
{

    public class Calculator
    {
        public int Add(params int[] nums)
        {
            //int sum = 0;

            //foreach (var num in nums)
            //{
            //    sum += num;
            //}

            //return sum;

            return nums.Sum(); // must import system.Linq;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //var point = new Point(1, 1);
            //int some = 'a'; // actually converts this to int 97
            //Console.WriteLine(some);

            //point.Move(4, 3);

            //Console.WriteLine("Using Move with two integers => Point: {0}, {1}", point.X, point.Y);

            //point.Move(new Point('a', 'b'));

            //Console.WriteLine("Using Move with new point object => Point: {0}, {1}", point.X, point.Y);

            //point.Alter(point.X, point.Y);

            //Console.WriteLine("Using my custom Alter method => Point: {0}, {1}", point.X, point.Y);

            try
            {
                var num = int.Parse("as");
            }
            catch (Exception)
            {

                Console.WriteLine("Parse to integer has failed."); ;
            }

            int number;
            var result = int.TryParse("as", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");

        }

        static void UseParams()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2, 3, 4, 32); // we can call it with a varying number of parameters as integers
            var arrayResult = calc.Add(new int[] { 1, 32, 13, 2 }); // OR with array notation

            Console.WriteLine(result);
        }

        static void UsePoints()
        {
            try
            {
                var pointTwo = new Point(1, 1);
                pointTwo.Move(null);

                Console.WriteLine("Try catch for null errors => Point: {0}, {1}", pointTwo.X, pointTwo.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
