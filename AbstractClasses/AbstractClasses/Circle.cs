﻿namespace AbstractClasses
{
    public class Circle : Shape
    {
        public int Circumference { get; set; }
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }
}
