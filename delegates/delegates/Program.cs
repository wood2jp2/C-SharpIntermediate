using System;

namespace delegates
{
    class Program
    {
        delegate int Del(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Del del = (x, y) => x + y;
            int sum = del(3, 4);
            int sum2 = Add(12, 32);
            Console.WriteLine(sum);
        }
    }
}
