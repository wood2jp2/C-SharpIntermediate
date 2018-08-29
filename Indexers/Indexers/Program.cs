using System;

namespace Indexers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Josh";
            Console.WriteLine(cookie["name"]);
        }
    }
}
