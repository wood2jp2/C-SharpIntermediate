using System;

namespace MethodOverriding
{

    public class Circle : Shape
    {
         // This overrides the base (Shape) implementation of Draw
        public override void Draw()
        {
            Console.WriteLine("draw circle");
        }
    }

    public class Rectangle : Shape
    {
        // This overrides the base (Shape) implementation of Draw
        public override void Draw()
        {
            Console.WriteLine("draw rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public ShapeType Type { get; set; }

        public virtual void Draw()
        {

        }

        // You don't need a ShapeType if you're making separate classes.
        // public ShapeType Type { get; set; }
    }
}
