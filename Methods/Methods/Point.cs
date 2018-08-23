using System;
namespace Methods
{
    public class Point
    {

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Alter (int x, int y) {
            X += x;
            Y += y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {

            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y); // this simplifies code as opposed to re-assigning X and Y manually
        }

    }
}
