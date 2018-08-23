using System;

namespace Methods
{

    public class Point {

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move (int x, int y) {
            this.X = x;
            this.Y = y;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var point = new Point(1, 1);

            point.Move(4, 3);

            Console.WriteLine("Point: {0}, {1}", point.X, point.Y);
        }
    }
}
