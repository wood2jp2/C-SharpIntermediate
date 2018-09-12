using System;

namespace AbstractClasses
{
    // This will throw an error if any abstract members on base Shape class are not overridden here
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
