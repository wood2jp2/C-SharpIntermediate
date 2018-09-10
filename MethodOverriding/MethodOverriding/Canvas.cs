using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle: 
                        Console.WriteLine("draw circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("draw rectangle");
                        break;
                }
            }
        }
    }
}
