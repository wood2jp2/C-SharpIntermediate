using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();

            var something = new Tuple<bool, string>(true, "josh");

            Console.WriteLine(something.Item2);
        }
    }
}
